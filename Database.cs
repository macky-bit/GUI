using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Raised when the MySQL server cannot be reached, carrying a message the
    /// student can act on instead of a raw connector error.
    /// </summary>
    public class DatabaseUnavailableException : Exception
    {
        public DatabaseUnavailableException(string message, Exception inner)
            : base(message, inner) { }
    }

    /// <summary>
    /// Owns the MySQL connection and the schema. Call <see cref="EnsureCreated"/> once
    /// at startup; every other class then just asks for an open connection.
    /// </summary>
    public static class Database
    {
        /// <summary>Schema name, kept in one place so the SQL below and Workbench agree.</summary>
        public const string SchemaName = "dmmmsu_maintenance";

        private static string _connectionString;

        /// <summary>Connection string from App.config, with the schema name filled in.</summary>
        public static string ConnectionString
        {
            get
            {
                if (_connectionString != null) return _connectionString;

                var configured = ConfigurationManager.ConnectionStrings["MaintenanceDb"];
                var builder = new MySqlConnectionStringBuilder(
                    configured != null && !string.IsNullOrWhiteSpace(configured.ConnectionString)
                        ? configured.ConnectionString
                        : "Server=localhost;Port=3306;Uid=root;Pwd=;");

                builder.Database = SchemaName;
                _connectionString = builder.ConnectionString;
                return _connectionString;
            }
        }

        /// <summary>Server description shown in error messages, without the password.</summary>
        public static string ServerDescription
        {
            get
            {
                var builder = new MySqlConnectionStringBuilder(ConnectionString);
                return builder.Server + ":" + builder.Port + " (user '" + builder.UserID + "')";
            }
        }

        /// <summary>Opens a connection to the portal schema.</summary>
        public static MySqlConnection OpenConnection()
        {
            var connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (MySqlException error)
            {
                connection.Dispose();
                throw Unavailable(error);
            }
        }

        /// <summary>
        /// Creates the schema and tables when missing, then makes sure there is
        /// something to sign in with. Safe to call on every launch.
        /// </summary>
        public static void EnsureCreated()
        {
            CreateSchema();

            using (var connection = OpenConnection())
            {
                CreateTables(connection);
                ImportLegacyTextFiles(connection);
                SeedDemoData(connection);
            }
        }

        /// <summary>Connects without naming a database so the schema itself can be created.</summary>
        private static void CreateSchema()
        {
            var builder = new MySqlConnectionStringBuilder(ConnectionString);
            builder.Database = string.Empty;

            try
            {
                using (var connection = new MySqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Execute(connection,
                        "CREATE DATABASE IF NOT EXISTS `" + SchemaName + "` " +
                        "CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;");
                }
            }
            catch (MySqlException error)
            {
                throw Unavailable(error);
            }
        }

        private static void CreateTables(MySqlConnection connection)
        {
            Execute(connection,
                "CREATE TABLE IF NOT EXISTS accounts (" +
                "  username      VARCHAR(30)  NOT NULL," +
                "  full_name     VARCHAR(80)  NOT NULL," +
                "  password_hash VARCHAR(64)  NOT NULL," +
                "  password_salt VARCHAR(32)  NOT NULL," +
                "  role          VARCHAR(20)  NOT NULL DEFAULT 'Student'," +
                "  registered_on DATETIME     NOT NULL," +
                "  PRIMARY KEY (username)" +
                ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;");

            Execute(connection,
                "CREATE TABLE IF NOT EXISTS requests (" +
                "  request_id  VARCHAR(12)  NOT NULL," +
                "  username    VARCHAR(30)  NOT NULL," +
                "  room        VARCHAR(80)  NOT NULL," +
                "  facility    VARCHAR(80)  NOT NULL," +
                "  category    VARCHAR(40)  NOT NULL," +
                "  priority    VARCHAR(10)  NOT NULL," +
                "  description TEXT         NULL," +
                "  attachment  VARCHAR(260) NULL," +
                "  status      VARCHAR(20)  NOT NULL," +
                "  filed_on    DATETIME     NOT NULL," +
                "  PRIMARY KEY (request_id)," +
                "  KEY ix_requests_username (username)," +
                "  CONSTRAINT fk_requests_account FOREIGN KEY (username)" +
                "    REFERENCES accounts (username) ON UPDATE CASCADE ON DELETE CASCADE" +
                ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;");
        }

        #region Command helpers

        /// <summary>Runs a statement that returns no rows.</summary>
        public static int Execute(MySqlConnection connection, string sql,
            params MySqlParameter[] parameters)
        {
            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddRange(parameters);
                return command.ExecuteNonQuery();
            }
        }

        /// <summary>Runs a statement and returns the first column of the first row.</summary>
        public static object ExecuteScalar(MySqlConnection connection, string sql,
            params MySqlParameter[] parameters)
        {
            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddRange(parameters);
                return command.ExecuteScalar();
            }
        }

        /// <summary>Runs a query and maps every row with the supplied projection.</summary>
        public static List<T> Query<T>(MySqlConnection connection, string sql,
            Func<IDataRecord, T> map, params MySqlParameter[] parameters)
        {
            var results = new List<T>();
            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddRange(parameters);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) results.Add(map(reader));
                }
            }
            return results;
        }

        /// <summary>Named parameter, with null mapped to SQL NULL.</summary>
        public static MySqlParameter Param(string name, object value)
        {
            return new MySqlParameter(name, value ?? DBNull.Value);
        }

        /// <summary>Reads a string column, treating SQL NULL as empty.</summary>
        public static string Text(IDataRecord row, int index)
        {
            return row.IsDBNull(index) ? string.Empty : row.GetString(index);
        }

        #endregion

        #region First-run data

        /// <summary>
        /// Moves records from the old pipe-delimited files into MySQL the first time
        /// the database is used, so an existing install keeps its history.
        /// </summary>
        private static void ImportLegacyTextFiles(MySqlConnection connection)
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "DMMMSU_Maintenance");

            ImportAccounts(connection, Path.Combine(folder, "accounts.txt"));
            ImportRequests(connection, Path.Combine(folder, "requests.txt"));
        }

        private static void ImportAccounts(MySqlConnection connection, string path)
        {
            foreach (var fields in ReadLegacyRecords(path, 6))
            {
                Execute(connection,
                    "INSERT IGNORE INTO accounts " +
                    "(username, full_name, password_hash, password_salt, role, registered_on) " +
                    "VALUES (@username, @fullName, @hash, @salt, @role, @registeredOn);",
                    Param("@username", fields[0]),
                    Param("@fullName", fields[1]),
                    Param("@hash", fields[2]),
                    Param("@salt", fields[3]),
                    Param("@role", fields[4]),
                    Param("@registeredOn", ParseDate(fields[5])));
            }
            MarkImported(path);
        }

        private static void ImportRequests(MySqlConnection connection, string path)
        {
            foreach (var fields in ReadLegacyRecords(path, 10))
            {
                Execute(connection,
                    "INSERT IGNORE INTO requests " +
                    "(request_id, username, room, facility, category, priority, " +
                    " description, attachment, status, filed_on) " +
                    "VALUES (@id, @username, @room, @facility, @category, @priority, " +
                    "        @description, @attachment, @status, @filedOn);",
                    Param("@id", fields[0]),
                    Param("@username", fields[1]),
                    Param("@room", fields[2]),
                    Param("@facility", fields[3]),
                    Param("@category", fields[4]),
                    Param("@priority", fields[5]),
                    Param("@description", fields[6]),
                    Param("@attachment", fields[7]),
                    Param("@status", fields[8]),
                    Param("@filedOn", ParseDate(fields[9])));
            }
            MarkImported(path);
        }

        private static IEnumerable<string[]> ReadLegacyRecords(string path, int expectedFieldCount)
        {
            if (!File.Exists(path)) yield break;

            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var fields = line.Split('|');
                if (fields.Length < expectedFieldCount) continue;
                yield return fields;
            }
        }

        /// <summary>Renames an imported file so the next launch does not re-read it.</summary>
        private static void MarkImported(string path)
        {
            if (!File.Exists(path)) return;

            try
            {
                string archived = path + ".imported";
                if (File.Exists(archived)) File.Delete(archived);
                File.Move(path, archived);
            }
            catch (IOException)
            {
                // Keeping the original file is harmless; INSERT IGNORE makes re-import a no-op
            }
        }

        private static DateTime ParseDate(string value)
        {
            DateTime parsed;
            return DateTime.TryParse(value, out parsed) ? parsed : DateTime.Now;
        }

        /// <summary>
        /// Gives a brand-new database a sample account and request history so the
        /// dashboard has something to show before anything is filed.
        /// </summary>
        private static void SeedDemoData(MySqlConnection connection)
        {
            long accountCount = Convert.ToInt64(ExecuteScalar(connection, "SELECT COUNT(*) FROM accounts;"));
            if (accountCount > 0) return;

            string salt = PasswordHasher.CreateSalt();
            Execute(connection,
                "INSERT INTO accounts " +
                "(username, full_name, password_hash, password_salt, role, registered_on) " +
                "VALUES (@username, @fullName, @hash, @salt, 'Student', @registeredOn);",
                Param("@username", "student"),
                Param("@fullName", "Juan Dela Cruz"),
                Param("@hash", PasswordHasher.Hash("student123", salt)),
                Param("@salt", salt),
                Param("@registeredOn", DateTime.Now));

            SeedRequest(connection, "REQ-0001", "Room 201", "Air Conditioner", "Electrical", "High",
                "Aircon is not cooling and makes a loud rattling sound.", RequestStatus.InProgress, -2);
            SeedRequest(connection, "REQ-0002", "Comp Lab 1", "Desktop Computer", "IT Equipment", "Medium",
                "Unit 14 will not power on.", RequestStatus.Completed, -9);
            SeedRequest(connection, "REQ-0003", "Library", "Ceiling Light", "Electrical", "Low",
                "Two ceiling lights near the reading area are flickering.", RequestStatus.Pending, -1);
            SeedRequest(connection, "REQ-0004", "Room 105", "Window", "Carpentry", "Medium",
                "Window latch is broken so it will not stay closed.", RequestStatus.Cancelled, -14);
        }

        private static void SeedRequest(MySqlConnection connection, string id, string room,
            string facility, string category, string priority, string description,
            string status, int daysAgo)
        {
            Execute(connection,
                "INSERT INTO requests " +
                "(request_id, username, room, facility, category, priority, " +
                " description, attachment, status, filed_on) " +
                "VALUES (@id, 'student', @room, @facility, @category, @priority, " +
                "        @description, '', @status, @filedOn);",
                Param("@id", id),
                Param("@room", room),
                Param("@facility", facility),
                Param("@category", category),
                Param("@priority", priority),
                Param("@description", description),
                Param("@status", status),
                Param("@filedOn", DateTime.Now.AddDays(daysAgo)));
        }

        #endregion

        /// <summary>Turns a connector error into guidance the student can follow.</summary>
        private static DatabaseUnavailableException Unavailable(MySqlException error)
        {
            string advice;
            switch (error.Number)
            {
                case 0:
                case 1042:
                case 1043:
                    advice = "Cannot reach the MySQL server at " + ServerDescription + "." +
                             Environment.NewLine + Environment.NewLine +
                             "Make sure MySQL is installed and the service is running, " +
                             "then try again.";
                    break;
                case 1045:
                    advice = "MySQL rejected the username or password for " + ServerDescription + "." +
                             Environment.NewLine + Environment.NewLine +
                             "Update the 'MaintenanceDb' connection string in " +
                             "WindowsFormsApp1.exe.config so it matches your MySQL account.";
                    break;
                default:
                    advice = "MySQL reported an error (code " + error.Number + "):" +
                             Environment.NewLine + error.Message;
                    break;
            }
            return new DatabaseUnavailableException(advice, error);
        }
    }
}
