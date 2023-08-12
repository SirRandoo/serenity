/*
    The table schema for a "user" within the bot. Users are people that use the
    bot's functions (either directly or indirectly).

    Columns:
        user_id -> The id of the user on Discord.
 */
CREATE TABLE Users
(
    user_id BIGINT PRIMARY KEY
);
