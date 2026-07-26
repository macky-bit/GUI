using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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

    /// <summary>
    /// File-backed storage for accounts and requests. Records live under the user's
    /// AppData folder as pipe-delimited lines so the app needs no database engine.
    /// </summary>
    public static class MaintenanceStore
    {
        private static readonly string StoreFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DMMMSU_Maintenance");

        private static readonly string AccountsFile = Path.Combine(StoreFolder, "accounts.txt");
        private static readonly string RequestsFile = Path.Combine(StoreFolder, "requests.txt");

        private static List<UserAccount> _accounts;
        private static List<MaintenanceRequest> _requests;

        #region Accounts

        public static bool UsernameExists(string username)
        {
            return LoadAccounts().Any(a =>
                string.Equals(a.Username, username, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>Creates an account. Returns false when the username is already taken.</summary>
        public static bool TryRegister(string username, string fullName, string password, out string error)
        {
            error = null;
            if (UsernameExists(username))
            {
                error = "That username is already taken. Please choose another one.";
                return false;
            }

            string salt = CreateSalt();
            var account = new UserAccount
            {
                Username = username.Trim(),
                FullName = fullName.Trim(),
                PasswordSalt = salt,
                PasswordHash = HashPassword(password, salt),
                Role = "Student",
                RegisteredOn = DateTime.Now
            };

            LoadAccounts().Add(account);
            SaveAccounts();
            return true;
        }

        /// <summary>Returns the matching account, or null when the credentials are wrong.</summary>
        public static UserAccount Authenticate(string username, string password)
        {
            var account = LoadAccounts().FirstOrDefault(a =>
                string.Equals(a.Username, username, StringComparison.OrdinalIgnoreCase));

            if (account == null) return null;
            return HashPassword(password, account.PasswordSalt) == account.PasswordHash ? account : null;
        }

        public static bool TryChangePassword(string username, string currentPassword, string newPassword, out string error)
        {
            error = null;
            var account = Authenticate(username, currentPassword);
            if (account == null)
            {
                error = "Your current password is incorrect.";
                return false;
            }

            account.PasswordSalt = CreateSalt();
            account.PasswordHash = HashPassword(newPassword, account.PasswordSalt);
            SaveAccounts();
            return true;
        }

        public static void UpdateFullName(string username, string fullName)
        {
            var account = LoadAccounts().FirstOrDefault(a =>
                string.Equals(a.Username, username, StringComparison.OrdinalIgnoreCase));
            if (account == null) return;

            account.FullName = fullName.Trim();
            SaveAccounts();
        }

        #endregion

        #region Requests

        public static List<MaintenanceRequest> GetRequestsFor(string username)
        {
            return LoadRequests()
                .Where(r => string.Equals(r.Username, username, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(r => r.FiledOn)
                .ToList();
        }

        public static int CountByStatus(string username, string status)
        {
            return GetRequestsFor(username).Count(r => r.Status == status);
        }

        public static MaintenanceRequest AddRequest(MaintenanceRequest request)
        {
            var all = LoadRequests();
            request.RequestId = NextRequestId(all);
            request.Status = RequestStatus.Pending;
            request.FiledOn = DateTime.Now;
            all.Add(request);
            SaveRequests();
            return request;
        }

        public static bool CancelRequest(string requestId)
        {
            var request = LoadRequests().FirstOrDefault(r => r.RequestId == requestId);
            if (request == null || request.Status == RequestStatus.Completed
                               || request.Status == RequestStatus.Cancelled)
            {
                return false;
            }

            request.Status = RequestStatus.Cancelled;
            SaveRequests();
            return true;
        }

        private static string NextRequestId(List<MaintenanceRequest> all)
        {
            int highest = 0;
            foreach (var request in all)
            {
                int number;
                string digits = (request.RequestId ?? string.Empty).Replace("REQ-", string.Empty);
                if (int.TryParse(digits, out number) && number > highest) highest = number;
            }
            return "REQ-" + (highest + 1).ToString("D4");
        }

        #endregion

        #region Persistence

        private static List<UserAccount> LoadAccounts()
        {
            if (_accounts != null) return _accounts;

            _accounts = new List<UserAccount>();
            foreach (var fields in ReadRecords(AccountsFile, 6))
            {
                _accounts.Add(new UserAccount
                {
                    Username = fields[0],
                    FullName = fields[1],
                    PasswordHash = fields[2],
                    PasswordSalt = fields[3],
                    Role = fields[4],
                    RegisteredOn = ParseDate(fields[5])
                });
            }

            if (_accounts.Count == 0) SeedDemoData();
            return _accounts;
        }

        private static void SaveAccounts()
        {
            WriteRecords(AccountsFile, _accounts.Select(a => new[]
            {
                a.Username, a.FullName, a.PasswordHash, a.PasswordSalt, a.Role,
                a.RegisteredOn.ToString("o")
            }));
        }

        private static List<MaintenanceRequest> LoadRequests()
        {
            if (_requests != null) return _requests;

            _requests = new List<MaintenanceRequest>();
            foreach (var fields in ReadRecords(RequestsFile, 10))
            {
                _requests.Add(new MaintenanceRequest
                {
                    RequestId = fields[0],
                    Username = fields[1],
                    Room = fields[2],
                    Facility = fields[3],
                    Category = fields[4],
                    Priority = fields[5],
                    Description = fields[6],
                    AttachmentPath = fields[7],
                    Status = fields[8],
                    FiledOn = ParseDate(fields[9])
                });
            }
            return _requests;
        }

        private static void SaveRequests()
        {
            WriteRecords(RequestsFile, _requests.Select(r => new[]
            {
                r.RequestId, r.Username, r.Room, r.Facility, r.Category, r.Priority,
                r.Description, r.AttachmentPath, r.Status, r.FiledOn.ToString("o")
            }));
        }

        private static IEnumerable<string[]> ReadRecords(string path, int expectedFieldCount)
        {
            if (!File.Exists(path)) yield break;

            foreach (var line in File.ReadAllLines(path, Encoding.UTF8))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var fields = line.Split('|').Select(Unescape).ToArray();
                if (fields.Length < expectedFieldCount) continue;
                yield return fields;
            }
        }

        private static void WriteRecords(string path, IEnumerable<string[]> records)
        {
            Directory.CreateDirectory(StoreFolder);
            var lines = records.Select(fields => string.Join("|", fields.Select(Escape)));
            File.WriteAllLines(path, lines.ToArray(), Encoding.UTF8);
        }

        private static string Escape(string value)
        {
            return (value ?? string.Empty)
                .Replace("\\", "\\\\").Replace("|", "\\p")
                .Replace("\r", "\\r").Replace("\n", "\\n");
        }

        private static string Unescape(string value)
        {
            var result = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != '\\' || i + 1 >= value.Length)
                {
                    result.Append(value[i]);
                    continue;
                }

                i++;
                switch (value[i])
                {
                    case 'p': result.Append('|'); break;
                    case 'r': result.Append('\r'); break;
                    case 'n': result.Append('\n'); break;
                    default: result.Append(value[i]); break;
                }
            }
            return result.ToString();
        }

        private static DateTime ParseDate(string value)
        {
            DateTime parsed;
            return DateTime.TryParse(value, out parsed) ? parsed : DateTime.Now;
        }

        #endregion

        #region Password hashing

        private static string CreateSalt()
        {
            var salt = new byte[16];
            using (var generator = new RNGCryptoServiceProvider()) generator.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }

        private static string HashPassword(string password, string salt)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(salt + "|" + password);
                return Convert.ToBase64String(sha.ComputeHash(bytes));
            }
        }

        #endregion

        /// <summary>
        /// Gives a brand-new install a sample account and request history so the
        /// dashboard has something to show before the user files anything.
        /// </summary>
        private static void SeedDemoData()
        {
            string salt = CreateSalt();
            _accounts.Add(new UserAccount
            {
                Username = "student",
                FullName = "Juan Dela Cruz",
                PasswordSalt = salt,
                PasswordHash = HashPassword("student123", salt),
                Role = "Student",
                RegisteredOn = DateTime.Now
            });
            SaveAccounts();

            // Only invent history on a truly empty install, never over saved requests
            if (File.Exists(RequestsFile)) return;

            _requests = new List<MaintenanceRequest>
            {
                NewSeed("REQ-0001", "Room 201", "Air Conditioner", "Electrical", "High",
                        "Aircon is not cooling and makes a loud rattling sound.",
                        RequestStatus.InProgress, -2),
                NewSeed("REQ-0002", "Comp Lab 1", "Desktop Computer", "IT Equipment", "Medium",
                        "Unit 14 will not power on.", RequestStatus.Completed, -9),
                NewSeed("REQ-0003", "Library", "Ceiling Light", "Electrical", "Low",
                        "Two ceiling lights near the reading area are flickering.",
                        RequestStatus.Pending, -1),
                NewSeed("REQ-0004", "Room 105", "Window", "Carpentry", "Medium",
                        "Window latch is broken so it will not stay closed.",
                        RequestStatus.Cancelled, -14)
            };
            SaveRequests();
        }

        private static MaintenanceRequest NewSeed(string id, string room, string facility,
            string category, string priority, string description, string status, int daysAgo)
        {
            return new MaintenanceRequest
            {
                RequestId = id,
                Username = "student",
                Room = room,
                Facility = facility,
                Category = category,
                Priority = priority,
                Description = description,
                AttachmentPath = string.Empty,
                Status = status,
                FiledOn = DateTime.Now.AddDays(daysAgo)
            };
        }
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
