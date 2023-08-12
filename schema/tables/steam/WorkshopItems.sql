/*
    The table schema for an item on the Steam workshop.

    Columns:
        item_id     -> The id of the item on the Steam workshop.
        app_id      -> The id of the application on Steam.
        name        -> The name of the workshop item at the time it was stored in the database.
        description -> The description of the workshop item at the time it was stored in the database.
 */
CREATE TABLE WorkshopItems
(
    item_id     BIGINT,
    app_id      BIGINT,
    name        VARCHAR(255) NOT NULL,
    description TEXT DEFAULT NULL,

    PRIMARY KEY (item_id, app_id)
);
