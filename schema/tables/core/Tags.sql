/*
    The table schema for a "tag". Tags are a way of storing content that
    can be retrieved in Discord through its id. The method by which content
    is retrieved is typically through Discord's slash commands framework,
    but may also be retrieved through text commands.

    Columns:
        tag_id     -> The unique id of the tag. Tag ids are unique to the channel they were created in.
        channel_id -> The channel the tag was created in.
        content    -> The content stored within the tag.
        author     -> The person that originally created the tag.
        updater    -> The person that last updated the tag.
        created_at -> The point in time the tag was originally created.
        updated_at -> The point in time the tag was last updated.
 */
CREATE TABLE Tags
(
    tag_id     VARCHAR(255),
    channel    BIGINT REFERENCES Channels (channel_id) ON DELETE CASCADE,
    content    TEXT      NOT NULL,
    author     BIGINT    NOT NULL REFERENCES Users (user_id) ON DELETE SET DEFAULT,
    updater    BIGINT    NOT NULL REFERENCES Users (user_id) ON DELETE SET DEFAULT,
    created_at TIMESTAMP NOT NULL,
    updated_at TIMESTAMP NOT NULL,

    PRIMARY KEY (tag_id, channel)
);
