using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    /// <summary>A registered portal account.</summary>
    public class UserAccount
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Role { get; set; }
        public DateTime RegisteredOn { get; set; }
    }

    /// <summary>A single maintenance request filed by a student.</summary>
    public class MaintenanceRequest
    {
        public string RequestId { get; set; }
        public string Username { get; set; }
        public string Room { get; set; }
        public string Facility { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }
        public string Status { get; set; }
        public DateTime FiledOn { get; set; }
    }

    /// <summary>Status values a request can hold, in lifecycle order.</summary>
    public static class RequestStatus
    {
        public const string Pending = "Pending";
        public const string InProgress = "In Progress";
        public const string Completed = "Completed";
        public const string Cancelled = "Cancelled";
    }

    /// <summary>Salted SHA-256 password hashing, shared by the store and the seeder.</summary>
    public static class PasswordHasher
    {
        public static string CreateSalt()
        {
            var salt = new byte[16];
            using (var generator = new RNGCryptoServiceProvider()) generator.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }

        public static string Hash(string password, string salt)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(salt + "|" + password);
                return Convert.ToBase64String(sha.ComputeHash(bytes));
            }
        }
    }

    /// <summary>
    /// Reads and writes accounts and requests in the MySQL schema created by
    /// <see cref="Database"/>. Every statement is parameterised, so user input is
    /// never concatenated into SQL.
    /// </summary>
    public static class MaintenanceStore
    {
        private const string AccountColumns =
            "username, full_name, password_hash, password_salt, role, registered_on";

        private const string RequestColumns =
            "request_id, username, room, facility, category, priority, " +
            "description, attachment, status, filed_on";

        #region Accounts

        public static bool UsernameExists(string username)
        {
            using (var connection = Database.OpenConnection())
            {
                long matches = Convert.ToInt64(Database.ExecuteScalar(connection,
                    "SELECT COUNT(*) FROM accounts WHERE username = @username;",
                    Database.Param("@username", (username ?? string.Empty).Trim())));
                return matches > 0;
            }
        }

        /// <summary>Creates an account. Returns false when the username is already taken.</summary>
        public static bool TryRegister(string username, string fullName, string password, out string error)
        {
            error = null;
            string account = (username ?? string.Empty).Trim();

            using (var connection = Database.OpenConnection())
            {
                long taken = Convert.ToInt64(Database.ExecuteScalar(connection,
                    "SELECT COUNT(*) FROM accounts WHERE username = @username;",
                    Database.Param("@username", account)));

                if (taken > 0)
                {
                    error = "That username is already taken. Please choose another one.";
                    return false;
                }

                string salt = PasswordHasher.CreateSalt();
                Database.Execute(connection,
                    "INSERT INTO accounts (" + AccountColumns + ") " +
                    "VALUES (@username, @fullName, @hash, @salt, 'Student', @registeredOn);",
                    Database.Param("@username", account),
                    Database.Param("@fullName", (fullName ?? string.Empty).Trim()),
                    Database.Param("@hash", PasswordHasher.Hash(password, salt)),
                    Database.Param("@salt", salt),
                    Database.Param("@registeredOn", DateTime.Now));
                return true;
            }
        }

        /// <summary>Returns the matching account, or null when the credentials are wrong.</summary>
        public static UserAccount Authenticate(string username, string password)
        {
            var account = FindAccount(username);
            if (account == null) return null;

            return PasswordHasher.Hash(password, account.PasswordSalt) == account.PasswordHash
                ? account
                : null;
        }

        public static UserAccount FindAccount(string username)
        {
            using (var connection = Database.OpenConnection())
            {
                var matches = Database.Query(connection,
                    "SELECT " + AccountColumns + " FROM accounts WHERE username = @username LIMIT 1;",
                    ReadAccount,
                    Database.Param("@username", (username ?? string.Empty).Trim()));

                return matches.Count > 0 ? matches[0] : null;
            }
        }

        public static bool TryChangePassword(string username, string currentPassword,
            string newPassword, out string error)
        {
            error = null;
            var account = Authenticate(username, currentPassword);
            if (account == null)
            {
                error = "Your current password is incorrect.";
                return false;
            }

            string salt = PasswordHasher.CreateSalt();
            using (var connection = Database.OpenConnection())
            {
                Database.Execute(connection,
                    "UPDATE accounts SET password_hash = @hash, password_salt = @salt " +
                    "WHERE username = @username;",
                    Database.Param("@hash", PasswordHasher.Hash(newPassword, salt)),
                    Database.Param("@salt", salt),
                    Database.Param("@username", account.Username));
            }
            return true;
        }

        public static void UpdateFullName(string username, string fullName)
        {
            using (var connection = Database.OpenConnection())
            {
                Database.Execute(connection,
                    "UPDATE accounts SET full_name = @fullName WHERE username = @username;",
                    Database.Param("@fullName", (fullName ?? string.Empty).Trim()),
                    Database.Param("@username", (username ?? string.Empty).Trim()));
            }
        }

        #endregion

        #region Requests

        public static List<MaintenanceRequest> GetRequestsFor(string username)
        {
            using (var connection = Database.OpenConnection())
            {
                return Database.Query(connection,
                    "SELECT " + RequestColumns + " FROM requests " +
                    "WHERE username = @username ORDER BY filed_on DESC;",
                    ReadRequest,
                    Database.Param("@username", (username ?? string.Empty).Trim()));
            }
        }

        public static int CountByStatus(string username, string status)
        {
            using (var connection = Database.OpenConnection())
            {
                return Convert.ToInt32(Database.ExecuteScalar(connection,
                    "SELECT COUNT(*) FROM requests WHERE username = @username AND status = @status;",
                    Database.Param("@username", (username ?? string.Empty).Trim()),
                    Database.Param("@status", status)));
            }
        }

        public static MaintenanceRequest AddRequest(MaintenanceRequest request)
        {
            using (var connection = Database.OpenConnection())
            {
                request.RequestId = NextRequestId(connection);
                request.Status = RequestStatus.Pending;
                request.FiledOn = DateTime.Now;

                Database.Execute(connection,
                    "INSERT INTO requests (" + RequestColumns + ") " +
                    "VALUES (@id, @username, @room, @facility, @category, @priority, " +
                    "        @description, @attachment, @status, @filedOn);",
                    Database.Param("@id", request.RequestId),
                    Database.Param("@username", request.Username),
                    Database.Param("@room", request.Room),
                    Database.Param("@facility", request.Facility),
                    Database.Param("@category", request.Category),
                    Database.Param("@priority", request.Priority),
                    Database.Param("@description", request.Description),
                    Database.Param("@attachment", request.AttachmentPath ?? string.Empty),
                    Database.Param("@status", request.Status),
                    Database.Param("@filedOn", request.FiledOn));

                return request;
            }
        }

        /// <summary>Cancels an open request. Finished requests are left untouched.</summary>
        public static bool CancelRequest(string requestId)
        {
            using (var connection = Database.OpenConnection())
            {
                int affected = Database.Execute(connection,
                    "UPDATE requests SET status = @cancelled " +
                    "WHERE request_id = @id AND status NOT IN (@completed, @cancelled);",
                    Database.Param("@cancelled", RequestStatus.Cancelled),
                    Database.Param("@id", requestId),
                    Database.Param("@completed", RequestStatus.Completed));

                return affected > 0;
            }
        }

        /// <summary>Builds the next REQ-#### id from the highest one already stored.</summary>
        private static string NextRequestId(MySqlConnection connection)
        {
            object highest = Database.ExecuteScalar(connection,
                "SELECT MAX(CAST(SUBSTRING(request_id, 5) AS UNSIGNED)) FROM requests;");

            long number = highest == null || highest == DBNull.Value ? 0 : Convert.ToInt64(highest);
            return "REQ-" + (number + 1).ToString("D4");
        }

        #endregion

        #region Row mapping

        private static UserAccount ReadAccount(IDataRecord row)
        {
            return new UserAccount
            {
                Username = Database.Text(row, 0),
                FullName = Database.Text(row, 1),
                PasswordHash = Database.Text(row, 2),
                PasswordSalt = Database.Text(row, 3),
                Role = Database.Text(row, 4),
                RegisteredOn = row.GetDateTime(5)
            };
        }

        private static MaintenanceRequest ReadRequest(IDataRecord row)
        {
            return new MaintenanceRequest
            {
                RequestId = Database.Text(row, 0),
                Username = Database.Text(row, 1),
                Room = Database.Text(row, 2),
                Facility = Database.Text(row, 3),
                Category = Database.Text(row, 4),
                Priority = Database.Text(row, 5),
                Description = Database.Text(row, 6),
                AttachmentPath = Database.Text(row, 7),
                Status = Database.Text(row, 8),
                FiledOn = row.GetDateTime(9)
            };
        }

        #endregion
    }

    /// <summary>Tracks who is signed in for the lifetime of the process.</summary>
    public static class AppSession
    {
        public static UserAccount CurrentUser { get; private set; }

        public static bool IsSignedIn { get { return CurrentUser != null; } }

        public static string DisplayName
        {
            get { return CurrentUser != null ? CurrentUser.FullName : "Guest"; }
        }

        public static void SignIn(UserAccount account) { CurrentUser = account; }

        public static void SignOut() { CurrentUser = null; }
    }
}
