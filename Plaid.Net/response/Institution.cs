using System.Collections.Generic;
using Newtonsoft.Json;

namespace Plaid.Net.response
{
    public class Institution
    {
        [JsonProperty("credentials")]
        public Credential Credentials { get; set; }

        [JsonProperty("has_mfa")]
        public bool HasMfa { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mfa")]
        public List<string> MfaTypes { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("products")]
        public List<string> Products { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        public class Credential
        {
            public Credential(string username, string password)
            {
                UserName = username;
                Password = password;
            }

            [JsonProperty("username")]
            public string UserName { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }
        }
    }
}
