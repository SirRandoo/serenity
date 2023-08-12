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

public enum ResultCode : short
{
    /// <summary>
    ///     Success.
    /// </summary>
    Ok = 1,

    /// <summary>
    ///     Generic failure.
    /// </summary>
    Fail = 2,

    /// <summary>
    ///     Your Steam client doesn't have a connection to the back-end.
    /// </summary>
    NoConnection = 3,

    /// <summary>
    ///     Password/ticket is invalid.
    /// </summary>
    InvalidPassword = 5,

    /// <summary>
    ///     The user is logged in elsewhere.
    /// </summary>
    LoggedInElsewhere = 6,

    /// <summary>
    ///     Protocol version is incorrect.
    /// </summary>
    InvalidProtocolVer = 7,

    /// <summary>
    ///     A parameter is incorrect.
    /// </summary>
    InvalidParam = 8,

    /// <summary>
    ///     File was not found.
    /// </summary>
    FileNotFound = 9,

    /// <summary>
    ///     Call method is busy - action not taken.
    /// </summary>
    Busy = 10,

    /// <summary>
    ///     Called object was in an invalid state.
    /// </summary>
    InvalidState = 11,

    /// <summary>
    ///     The name was invalid.
    /// </summary>
    InvalidName = 12,

    /// <summary>
    ///     The email was invalid.
    /// </summary>
    InvalidEmail = 13,

    /// <summary>
    ///     The name is not unique.
    /// </summary>
    DuplicateName = 14,

    /// <summary>
    ///     Access is denied.
    /// </summary>
    AccessDenied = 15,

    /// <summary>
    ///     Operation timed out.
    /// </summary>
    Timeout = 16,

    /// <summary>
    ///     The user is VAC2 banned.
    /// </summary>
    Banned = 17,

    /// <summary>
    ///     Account not found.
    /// </summary>
    AccountNotFound = 18,

    /// <summary>
    ///     The Steam ID was invalid.
    /// </summary>
    InvalidSteamId = 19,

    /// <summary>
    ///     The requested service is currently unavailable.
    /// </summary>
    ServiceUnavailable = 20,

    /// <summary>
    ///     The user is not logged on.
    /// </summary>
    NotLoggedOn = 21,

    /// <summary>
    ///     Request is pending, it may be in process or waiting on third
    ///     party.
    /// </summary>
    Pending = 22,

    /// <summary>
    ///     Encryption or decryption failed.
    /// </summary>
    EncryptionFailure = 23,

    /// <summary>
    ///     Insufficient privilege.
    /// </summary>
    InsufficientPrivilege = 24,

    /// <summary>
    ///     Too much of a good thing.
    /// </summary>
    LimitExceeded = 25,

    /// <summary>
    ///     Access has been removed (used for revoked guest passes.)
    /// </summary>
    Revoked = 26,

    /// <summary>
    ///     License/guest pass the user is trying to access is expired.
    /// </summary>
    Expired = 27,

    /// <summary>
    ///     Guess pass has been redeemed by account, cannot be used again.
    /// </summary>
    AlreadyRedeemed = 28,

    /// <summary>
    ///     The request is a duplicate and the action has already occurred in
    ///     the past,
    ///     ignored this time.
    /// </summary>
    DuplicateRequest = 29,

    /// <summary>
    ///     All the games in this guest pass redemption request are already
    ///     owned by
    ///     the user.
    /// </summary>
    AlreadyOwned = 30,

    /// <summary>
    ///     IP address not found.
    /// </summary>
    IpNotFound = 31,

    /// <summary>
    ///     Failed to write change to the data store.
    /// </summary>
    PersistFailed = 32,

    /// <summary>
    ///     Failed to acquire access lock for this operation.
    /// </summary>
    LockingFailed = 33,

    /// <summary>
    ///     The logon session has been replaced.
    /// </summary>
    LogonSessionReplaced = 34,

    /// <summary>
    ///     Failed to connect.
    /// </summary>
    ConnectFailed = 35,

    /// <summary>
    ///     The authentication handshake has failed.
    /// </summary>
    HandshakeFailed = 36,

    /// <summary>
    ///     There has been a generic IO failure.
    /// </summary>
    IoFailure = 37,

    /// <summary>
    ///     The remote server has disconnected.
    /// </summary>
    RemoteDisconnect = 38,

    /// <summary>
    ///     Failed to find the shopping cart requested.
    /// </summary>
    ShoppingCartNotFound = 39,

    /// <summary>
    ///     A user blocked the action.
    /// </summary>
    Blocked = 40,

    /// <summary>
    ///     The target is ignoring sender.
    /// </summary>
    Ignored = 41,

    /// <summary>
    ///     Nothing matching the request found.
    /// </summary>
    NoMatch = 42,

    /// <summary>
    ///     The account is disabled.
    /// </summary>
    AccountDisabled = 43,

    /// <summary>
    ///     The service is not accepting content changes right now.
    /// </summary>
    ServiceReadOnly = 44,

    /// <summary>
    ///     Account doesn't have value, so this feature isn't available.
    /// </summary>
    AccountNotFeatured = 45,

    /// <summary>
    ///     Allowed to take this action, but only because requester is admin.
    /// </summary>
    AdministratorOk = 46,

    /// <summary>
    ///     A version mismatch in content transmitted within the Steam
    ///     protocol.
    /// </summary>
    ContentVersion = 47,

    /// <summary>
    ///     The current CM can't service the user making a request, user
    ///     should try another.
    /// </summary>
    TryAnotherCm = 48,

    /// <summary>
    ///     You are already logged in elsewhere, this cached credential login
    ///     has failed.
    /// </summary>
    PasswordRequiredToKickSession = 49,

    /// <summary>
    ///     The user is logged in elsewhere.
    /// </summary>
    /// <remarks>
    ///     Use <see cref="LoggedInElsewhere"/> instead.
    /// </remarks>
    AlreadyLoggedInElsewhere = 50,

    /// <summary>
    ///     Long running operation has suspended/paused. (eg. content
    ///     download.)
    /// </summary>
    Suspended = 51,

    /// <summary>
    ///     Operation has been canceled, typically by user. (eg. a content
    ///     download.)
    /// </summary>
    Cancelled = 52,

    /// <summary>
    ///     Operation cancelled because data is ill formed or unrecoverable.
    /// </summary>
    DataCorruption = 53,

    /// <summary>
    ///     Operation cancelled - not enough disk space.
    /// </summary>
    DiskFull = 54,

    /// <summary>
    ///     The remote or IPC call has failed.
    /// </summary>
    RemoteCallFailed = 55,

    /// <summary>
    ///     Password could not be verified as it's unset server side.
    /// </summary>
    PasswordUnset = 56,

    /// <summary>
    ///     External account (PSN, Facebook...) is not linked to a Steam
    ///     account.
    /// </summary>
    ExternalAccountUnliked = 57,

    /// <summary>
    ///     The sync cannot resume due to a conflict between the local and
    ///     remote files.
    /// </summary>
    RemoteFileConflict = 60,

    /// <summary>
    ///     The requested new password is not allowed.
    /// </summary>
    IllegalPassword = 61,

    /// <summary>
    ///     New value is the same as the old one. This is used for secret
    ///     question and answer.
    /// </summary>
    SameAsPreviousValue = 62,

    /// <summary>
    ///     Account login denied due to 2nd factor authentication failure.
    /// </summary>
    AccountLogonDenied = 63,

    /// <summary>
    ///     The requested new password is not legal.
    /// </summary>
    UseOldPassword = 64,

    /// <summary>
    ///     Account login denied due to auth code.
    /// </summary>
    LoginAuthCode = 65,

    /// <summary>
    ///     Account login denied due to 2nd factor failure - and no mail has
    ///     been sent.
    /// </summary>
    LogonDeniedNoMail = 66,

    /// <summary>
    ///     The user's hardware does not support Intel's Identity Protection
    ///     Technology (IPT)
    /// </summary>
    HardwareNotCapableOfIpt = 67,

    /// <summary>
    ///     Intel's Identity Protection Technology (IPT) has failed to
    ///     initialize.
    /// </summary>
    IptInitError = 68,

    /// <summary>
    ///     Operation failed due to parental control restrictions for current
    ///     user.
    /// </summary>
    ParentalControlRestricted = 69,

    /// <summary>
    ///     Facebook query returned an error.
    /// </summary>
    FacebookQueryError = 70,

    /// <summary>
    ///     Account login denied due to an expired auth code.
    /// </summary>
    ExpiredLoginAuthCode = 71,

    /// <summary>
    ///     The login failed due to an IP restriction.
    /// </summary>
    IpLoginRestrictionFailed = 72,

    /// <summary>
    ///     The current user's account is currently locked for use. This is
    ///     likely due to a
    ///     hijacking and pending ownership verification.
    /// </summary>
    AccountLockedDown = 73,

    /// <summary>
    ///     The logon failed because the account's email is not verified.
    /// </summary>
    AccountLogonDeniedVerifiedEmailRequired = 74,

    /// <summary>
    ///     There is no url matching the provided values.
    /// </summary>
    NoMatchingUrl = 75,

    /// <summary>
    ///     Bad response due to a parse failure, missing field, etc.
    /// </summary>
    BadResponse = 76,

    /// <summary>
    ///     The user cannot complete the action util they re-enter their
    ///     password.
    /// </summary>
    RequirePasswordReEntry = 77,

    /// <summary>
    ///     The value entered is outside the acceptable range.
    /// </summary>
    ValueOutOfRange = 78,

    /// <summary>
    ///     Something happened that we didn't expect to ever happen.
    /// </summary>
    UnexpectedError = 79,

    /// <summary>
    ///     The requested service has been configured to be unavailable.
    /// </summary>
    Disabled = 80,

    /// <summary>
    ///     The files submitted to the CEG server are not valid.
    /// </summary>
    InvalidCegSubmission = 81,

    /// <summary>
    ///     The device being used is not allowed to perform this action.
    /// </summary>
    RestrictedDevice = 82,

    /// <summary>
    ///     The action could not be completed because it is region
    ///     restricted.
    /// </summary>
    RegionLocked = 83,

    /// <summary>
    ///     Temporary ratelimit exceeded, try again later.
    /// </summary>
    /// <remarks>
    ///     Different from <see cref="LimitExceeded"/> which may be
    ///     permanent.
    /// </remarks>
    RateLimitExceeded = 84,

    /// <summary>
    ///     Need two-factor code to login.
    /// </summary>
    AccountLoginDeniedNeedTwoFactor = 85,

    /// <summary>
    ///     The thing we're trying to access has been deleted.
    /// </summary>
    ItemDeleted = 86,

    /// <summary>
    ///     Login attempt failed, try to throttle response to possible
    ///     attacker.
    /// </summary>
    AccountLoginDeniedThrottle = 87,

    /// <summary>
    ///     Two factor authentication (Steam Guard) code is incorrect.
    /// </summary>
    TwoFactorCodeMismatch = 88,

    /// <summary>
    ///     The activation code for two-factor authentication (Steam Guard)
    ///     didn't match.
    /// </summary>
    TwoFactorActivationCodeMismatch = 89,

    /// <summary>
    ///     The current account has been associated to multiple partners.
    /// </summary>
    AccountAssociatedToMultiplePartners = 90,

    /// <summary>
    ///     The data has not been modified.
    /// </summary>
    NotModified = 91,

    /// <summary>
    ///     The account does not have a mobile device associated with it.
    /// </summary>
    NoMobileDevice = 92,

    /// <summary>
    ///     The time presented is out of range or tolerance.
    /// </summary>
    TimeNotSynced = 93,

    /// <summary>
    ///     SMS code failure - no match, none pending, etc.
    /// </summary>
    SmsCodeFailed = 94,

    /// <summary>
    ///     Too many accounts access this resource.
    /// </summary>
    AccountLimitExceeded = 95,

    /// <summary>
    ///     Too many charges to this account.
    /// </summary>
    AccountActivityLimitExceeded = 96,

    /// <summary>
    ///     Too many changes to this phone.
    /// </summary>
    PhoneActivityLimitExceeded = 97,

    /// <summary>
    ///     Cannot refund to payment method, much use wallet.
    /// </summary>
    RefundToWallet = 98,

    /// <summary>
    ///     Cannot send an email.
    /// </summary>
    EmailSendFailure = 99,

    /// <summary>
    ///     Can't perform operation until payment has settled.
    /// </summary>
    NotSettled = 100,

    /// <summary>
    ///     The user needs to provide a valid captcha.
    /// </summary>
    NeedCaptcha = 101,

    /// <summary>
    ///     A game server login token owned by this token's owner has been
    ///     banned.
    /// </summary>
    GsltDenied = 102,

    /// <summary>
    ///     Game server owner is denied for some other reason such as account
    ///     locked,
    ///     community ban, vac ban, missing phone, etc.
    /// </summary>
    GsOwnerDenied = 103,

    /// <summary>
    ///     The type of thing we were requested to act on is invalid.
    /// </summary>
    InvalidItemType = 104,

    /// <summary>
    ///     The ip address has been banned from taking this action.
    /// </summary>
    IpBanned = 105,

    /// <summary>
    ///     The game server login token (GSLT) has expired from disuse; it
    ///     can be reset
    ///     for user.
    /// </summary>
    GsltExpired = 106,

    /// <summary>
    ///     User doesn't have enough wallet funds to complete this action.
    /// </summary>
    InsufficientFunds = 107,

    /// <summary>
    ///     There are too many of this thing pending already.
    /// </summary>
    TooManyPending = 108
}