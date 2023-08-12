/*
    The table schema for a Discord "channel".

    Columns:
        channel_id -> The id of the channel on Discord.
        guild      -> The guild that owns the channel.
 */
CREATE TABLE Channels
(
    channel_id BIGINT PRIMARY KEY,
    guild      BIGINT REFERENCES Guilds (id) ON DELETE CASCADE
);
