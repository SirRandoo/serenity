/*
    Represents the platforms supported by the bot.
 */
CREATE TYPE StreamPlatforms AS ENUM ('unknown', 'twitch', 'trovo', 'glimesh');

/*
    The table schema for a user's identity on a given live streaming platform.

    Columns:
        user_id        -> The id of the user on Discord.
        platform       -> The platform identity being described.
        user_identity  -> The username, or id, of the user on the platform.
        is_advertising -> Whether the user is currently requesting advertisements be posted for the platform.
 */
CREATE TABLE UserStreamData
(
    user_id        BIGINT REFERENCES Users (user_id) ON DELETE CASCADE,
    platform       StreamPlatforms DEFAULT UNKNOWN,
    user_identity  VARCHAR(255)    DEFAULT NULL,
    is_advertising BOOLEAN         DEFAULT FALSE,

    PRIMARY KEY (user_id, platform)
);
