using Newtonsoft.Json;
using RestSharp;

namespace Plaid.Net.response
{
    public class TokenResponse
    {
        private readonly IRestResponse _response;

        public TokenResponse(IRestResponse response)
        {
            _response = response;
        }

        public ExchangeToken GetAccessTokenObject()
        {
            return JsonConvert.DeserializeObject<ExchangeToken>(_response.Content);
        }
    }
}
