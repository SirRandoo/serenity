/*
    Incident types are the different types of incidents natively supported by
    the bot. Incident types describe what type of incident occurred at a given
    point in time.
 */
CREATE TYPE IncidentTypes AS ENUM ('unknown', 'ban', 'mute');


/*
    The table schema for a "incident" within the bot. Incidents are moderator
    actions that occurred at a given point in time.

    Columns:
        incident_id -> The auto-generated id of the incident.
        type        -> The type of moderation action that took place.
        offender    -> The person that sparked the incident.
        moderator   -> The person that took action against the offender.
        reason      -> The optional reason for the action that was taken.
        occurred_at -> The point in time the incident occurred.
 */
CREATE TABLE Incidents
(
    incident_id   UUID PRIMARY KEY,
    incident_type IncidentTypes NOT NULL,
    offender      BIGINT        NOT NULL REFERENCES Users (user_id) ON DELETE CASCADE,
    moderator     BIGINT        NOT NULL REFERENCES Users (user_id) ON DELETE SET DEFAULT,
    reason        TEXT          NULL,
    occurred_at   TIMESTAMP     NOT NULL
);
