// MIT License
// 
// Copyright (c) 2023 SirRandoo
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

namespace Serenity.Apis.Steam;

public record RootObject(Response Response);

public record Response(int Result, int ResultCount, PublishedFileDetails[] PublishedFileDetails);

public record PublishedFileDetails(
    string PublishedFileId,
    int Result,
    string Creator,
    int CreatorAppId,
    int ConsumerAppId,
    string FileName,
    int FileSize,
    string FileUrl,
    string HContentFile,
    string PreviewUrl,
    string HContentPreview,
    string Title,
    string Description,
    int TimeCreated,
    int TimeUpdated,
    int Visibility,
    int Banned,
    string BanReason,
    int Subscriptions,
    int Favorited,
    int LifetimeSubscriptions,
    int LifetimeFavorited,
    int Views,
    Tags[] Tags
);

public record Tags(string Tag);