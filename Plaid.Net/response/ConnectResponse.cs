using RestSharp;

namespace Plaid.Net.response
{
    public class ConnectResponse
    {
        private readonly IRestResponse _restResponse;

        public ConnectResponse(IRestResponse restResponse)
        {
            _restResponse = restResponse;
        }

        public AccountsResponse AccountResponse()
        {
            return new AccountsResponse(_restResponse);
        }

        public TransactionsResponse TransactionsResponse()
        {
            return new TransactionsResponse(_restResponse);
        }
    }
}
