// MIT License
// 
// Copyright (c) 2022 SirRandoo
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;

namespace Serenity.Models.Data;

/// <summary>
///     Represents the various incidents supported by the bot.
/// </summary>
public enum IncidentType
{
    /// <summary>
    ///     Indicates the incident wasn't initialized properly, or referenced
    ///     a value that no longer exists.
    /// </summary>
    Unknown,

    /// <summary>
    ///     Indicates the incident was a user being banned from the guild.
    /// </summary>
    Ban,

    /// <summary>
    ///     Indicates the incident was a user being muted in the guild.
    /// </summary>
    Mute
}

/// <summary>
///     Represents an incident a user had with a moderator.
/// </summary>
/// <param name="Id">An auto-generated id representing the incident.</param>
/// <param name="Type">The type of incident that occurred.</param>
/// <param name="Offender">The person that caused the incident.</param>
/// <param name="Moderator">
///     The person that took action against the <see cref="Offender"/>.
/// </param>
/// <param name="Reason">
///     An optional reason why the <see cref="Offender"/> required
///     moderator intervention.
/// </param>
/// <param name="OccurredAt">The date and time the incident occurred.</param>
/// <remarks>
///     Incidents are read-only once they've been created. This means
///     that moderators are not allowed to make revisions to pre-existing
///     incidents. They should instead create a new incident for the
///     user.
/// </remarks>
public record Incident(Guid Id, IncidentType Type, User Offender, User Moderator, string Reason, DateTime OccurredAt);
