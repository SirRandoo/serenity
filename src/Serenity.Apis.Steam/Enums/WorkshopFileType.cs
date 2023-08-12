namespace Serenity.Apis.Steam;

public enum WorkshopFileType : short
{
    /// <summary>
    ///     Normal workshop item that can be subscribed to.
    /// </summary>
    Community = 0,

    /// <summary>
    ///     Workshop item that is meant to be voted on for the purpose of
    ///     selling in-game.
    /// </summary>
    MicroTransaction = 1,

    /// <summary>
    ///     A collection of workshop items.
    /// </summary>
    Collection = 2,

    /// <summary>
    ///     Artwork
    /// </summary>
    Art = 3,

    /// <summary>
    ///     External video.
    /// </summary>
    Video = 4,

    /// <summary>
    ///     Screenshot.
    /// </summary>
    Screenshot = 5,
    [Obsolete("Used to be used for Greenlight game entries.")] Game = 6,
    [Obsolete("Used to be used for Greenlight software entries.")]
    Software = 7,
    [Obsolete("Used to be used for Greenlight concepts.")] Concept = 8,

    /// <summary>
    ///     Steam web guide.
    /// </summary>
    WebGuide = 9,

    /// <summary>
    ///     Application integrated guide.
    /// </summary>
    IntegratedGuide = 10,

    /// <summary>
    ///     Workshop merchandise meant to be voted on for the purpose of
    ///     being sold.
    /// </summary>
    Merch = 11,

    /// <summary>
    ///     Steam controller binding.
    /// </summary>
    ControllerBinding = 12,

    /// <summary>
    ///     Only used internally in Steam.
    /// </summary>
    SteamworksAccessInvite = 13,

    /// <summary>
    ///     Steam video.
    /// </summary>
    SteamVideo = 14,

    /// <summary>
    ///     Completely managed by the game, not the user, and not shown on
    ///     the web.
    /// </summary>
    GameManagedItem = 15
}