using Plaid.Net.request;
using Plaid.Net.response;

namespace Plaid.Net
{
    public interface IPlaidUserClient
    {
        void SetAccessToken(string accesstoken);
        string GetAccessToken();
        PlaidUserResponse ExchangeToken(string publicToken);
        ConnectResponse AuthenticateUser(Credentials credentials, string type, ConnectOptions connectOptions);
        ConnectResponse MfaConnectStep(string mfa, string type);
        //AccountsResponse AchAuth(Credentials credentials, string type, ConnectOptions connectOptions);
        //AccountsResponse MfaAuthStep(string mfa, string type);
        //AccountsResponse MfaAuthDeviceSelectionByDeviceType(string deviceType, string type);
        //AccountsResponse MfaAuthDeviceSelectionByDeviceMask(string deviceMask, string type);
        //ConnectResponse UpdateTransactions();
        //ConnectResponse UpdateTransactions(GetOptions options);
        //ConnectResponse UpdateCredentials(Credentials credentials, string type);
        //ConnectResponse UpdateWebhook(string webhook);
        //AccountsResponse UpdateAuth();
        //MessageResponse DeleteUser();
        //AccountsResponse CheckBalance();
        //InfoResponse Info(Credentials credentials, string type, InfoOptions options);
        //ConnectResponse AddProduct(string product, ConnectOptions options);
    }
}
