namespace Plaid.Net.Models
{
    public enum HttpStatusCodes
    {
        Success = 200,
        MfaRequired = 201,
        BadRequest = 400,
        Unauthorized = 401,
        RequestFailed = 402,
        CannotBeFound = 404
    }
}
