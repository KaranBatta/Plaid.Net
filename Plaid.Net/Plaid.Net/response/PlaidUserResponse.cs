using Newtonsoft.Json;
using RestSharp;

namespace Plaid.Net.response
{
    public class PlaidUserResponse
    {
        private readonly IRestResponse _response;

        public PlaidUserResponse(IRestResponse response)
        {
            _response = response;
        }

        public ExchangeToken GetAccessTokenObject()
        {
            return JsonConvert.DeserializeObject<ExchangeToken>(_response.Content);
        }
    }
}
