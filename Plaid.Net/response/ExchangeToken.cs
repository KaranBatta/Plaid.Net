using Newtonsoft.Json;

namespace Plaid.Net.response
{
    public class ExchangeToken
    {
        [JsonProperty("sandbox")]
        public bool Sandbox { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
