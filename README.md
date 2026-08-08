# DMMMSU Facility Maintenance Portal

A Windows Forms desktop app where students file and track facility maintenance
requests. Accounts and requests are stored in **MySQL**.

- **Framework:** .NET Framework 4.8 (C#, Windows Forms)
- **Database:** MySQL / MariaDB, schema `dmmmsu_maintenance`
- **Connector:** MySQL Connector/NET 8.0.33 (`lib\MySql.Data.dll`)

## Running the app

1. **Start MySQL.** Open the **XAMPP Control Panel** and press **Start** next to
   *MySQL*. The app needs the server listening on port 3306.
2. **Build and run** `GUI.csproj` from Visual Studio (F5), or run
   `bin\Debug\WindowsFormsApp1.exe` directly.

On first launch the app creates the schema and both tables by itself, so there
is nothing to set up in Workbench beforehand.

If MySQL is not running you get a **Database Unavailable** notice explaining what
to start, instead of a crash.

### Demo login

| Username  | Password     |
|-----------|--------------|
| `student` | `student123` |

Sign-up creates additional accounts; the demo account is only seeded into an
empty database.

## Database

The connection is configured in [App.config](App.config) under the
`MaintenanceDb` connection string:

```xml
<add name="MaintenanceDb"
     connectionString="Server=localhost;Port=3306;Uid=root;Pwd=;..."
     providerName="MySql.Data.MySqlClient" />
```

Change `Uid` and `Pwd` if your MySQL account is not the passwordless `root` that
XAMPP installs. The schema name is fixed in `Database.SchemaName`.

### Tables

`accounts` — one row per registered user.

| Column | Type | Notes |
|---|---|---|
| `username` | `VARCHAR(30)` | primary key |
| `full_name` | `VARCHAR(80)` | shown on the dashboard and profile |
| `password_hash` | `VARCHAR(64)` | salted SHA-256, never plain text |
| `password_salt` | `VARCHAR(32)` | per-account salt |
| `role` | `VARCHAR(20)` | defaults to `Student` |
| `registered_on` | `DATETIME` | |

`requests` — one row per maintenance request.

| Column | Type | Notes |
|---|---|---|
| `request_id` | `VARCHAR(12)` | primary key, format `REQ-0001` |
| `username` | `VARCHAR(30)` | foreign key to `accounts`, indexed |
| `room` | `VARCHAR(80)` | |
| `facility` | `VARCHAR(80)` | |
| `category` | `VARCHAR(40)` | Electrical, Carpentry, IT Equipment, … |
| `priority` | `VARCHAR(10)` | Low, Medium, High |
| `description` | `TEXT` | |
| `attachment` | `VARCHAR(260)` | optional file path |
| `status` | `VARCHAR(20)` | Pending, In Progress, Completed, Cancelled |
| `filed_on` | `DATETIME` | |

Deleting an account cascades to its requests; renaming one carries them along.

[database/schema.sql](database/schema.sql) holds the same DDL as a script you can
run in MySQL Workbench to rebuild the database by hand, plus a couple of useful
reporting queries.

## Code layout

| File | Responsibility |
|---|---|
| `Program.cs` | Entry point; creates the schema, then shows the login form |
| `Database.cs` | Connection, schema creation, seeding, error messages |
| `MaintenanceStore.cs` | All SQL for accounts and requests; session state |
| `UiTheme.cs` | Shared colours and fonts |
| `logIn.cs` / `register.cs` / `resetPassword.cs` | Authentication screens |
| `dashboard.cs` | Home screen with counts, recent requests, announcements |
| `request.cs` / `myRequests.cs` / `profile.cs` | Filing, listing, and account screens |

Every statement in `MaintenanceStore` is parameterised, so user input is never
concatenated into SQL.

### Dependencies

`lib\` holds the connector and its dependency assemblies. They are committed
because this project uses the old-style `.csproj` format without NuGet restore,
so the build resolves them straight from `HintPath`.

## Notes

- Passwords are stored as a salted SHA-256 hash. A forgotten password is reset
  by proving the current one, not by recovering the old value.
- "Remember Me" saves only the username, in
  `%AppData%\DMMMSU_Maintenance\remembered.txt` — it is a per-machine
  convenience, so it deliberately stays out of the database.
- An earlier version kept data in pipe-delimited text files. Those records are
  imported into MySQL automatically on first run and the originals are renamed
  to `*.imported` as a backup.
