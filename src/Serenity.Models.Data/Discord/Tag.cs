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
///     Represents a tag users can use to display the associated
///     <see cref="Content"/>.
/// </summary>
/// <param name="Id">
///     The unique id of the tag. Tag ids are guild-specific.
/// </param>
/// <param name="Content">
///     The information to display when the user uses the tag.
/// </param>
/// <param name="Guild">The guild the tag belongs to.</param>
/// <param name="Author">The person that created the tag originally.</param>
/// <param name="Updater">The person that last updated the tag.</param>
/// <param name="CreatedAt">The date and time the tag was created.</param>
/// <param name="UpdatedAt">The date and time the tag was last updated.</param>
public record Tag(string Id, string Content, Guild Guild, User Author, User Updater, DateTime CreatedAt, DateTime UpdatedAt);
