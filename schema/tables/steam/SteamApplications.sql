/*
    The table schema for an application on Steam.

    Columns:
        app_id -> The id of the guild on Discord.
        name   -> The name of the application at the time it was stored in the database.
 */
CREATE TABLE SteamApplications
(
    app_id BIGINT PRIMARY KEY,
    name   VARCHAR(255) NOT NULL
);
