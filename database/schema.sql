-- ---------------------------------------------------------------------------
-- DMMMSU Maintenance Portal - MySQL schema
--
-- The application creates this schema automatically on first launch, so you do
-- not need to run this script. It is kept here as documentation and so the
-- database can be rebuilt by hand in MySQL Workbench when needed.
-- ---------------------------------------------------------------------------

CREATE DATABASE IF NOT EXISTS dmmmsu_maintenance
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_general_ci;

USE dmmmsu_maintenance;

-- Portal accounts. Passwords are stored as a salted SHA-256 hash, never in
-- plain text; password_salt holds the per-account salt used to produce it.
CREATE TABLE IF NOT EXISTS accounts (
    username      VARCHAR(30)  NOT NULL,
    full_name     VARCHAR(80)  NOT NULL,
    password_hash VARCHAR(64)  NOT NULL,
    password_salt VARCHAR(32)  NOT NULL,
    role          VARCHAR(20)  NOT NULL DEFAULT 'Student',
    registered_on DATETIME     NOT NULL,
    PRIMARY KEY (username)
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;

-- Maintenance requests filed by students. Deleting an account removes its
-- requests, and renaming an account carries them along.
CREATE TABLE IF NOT EXISTS requests (
    request_id  VARCHAR(12)  NOT NULL,
    username    VARCHAR(30)  NOT NULL,
    room        VARCHAR(80)  NOT NULL,
    facility    VARCHAR(80)  NOT NULL,
    category    VARCHAR(40)  NOT NULL,
    priority    VARCHAR(10)  NOT NULL,
    description TEXT         NULL,
    attachment  VARCHAR(260) NULL,
    status      VARCHAR(20)  NOT NULL,
    filed_on    DATETIME     NOT NULL,
    PRIMARY KEY (request_id),
    KEY ix_requests_username (username),
    CONSTRAINT fk_requests_account
        FOREIGN KEY (username) REFERENCES accounts (username)
        ON UPDATE CASCADE
        ON DELETE CASCADE
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4;

-- ---------------------------------------------------------------------------
-- Handy queries while marking or debugging
-- ---------------------------------------------------------------------------

-- Every request with the name of the student who filed it
-- SELECT r.request_id, a.full_name, r.room, r.facility, r.status, r.filed_on
-- FROM requests r
-- JOIN accounts a ON a.username = r.username
-- ORDER BY r.filed_on DESC;

-- How many requests sit in each status
-- SELECT status, COUNT(*) AS total FROM requests GROUP BY status;
