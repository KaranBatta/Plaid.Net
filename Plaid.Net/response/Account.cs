using Newtonsoft.Json;

namespace Plaid.Net.response
{
    public class Account
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        
        [JsonProperty("_item")]
        public string Item { get; set; }

        [JsonProperty("_user")]
        public string UserId { get; set; }

        [JsonProperty("balance")]
        public Balance AccountBalance { get; set; }

        [JsonProperty("institution_type")]
        public string InstitutionType { get; set; }
        
        [JsonProperty("meta")]
        public Meta AccountMeta { get; set; }
        
        [JsonProperty("subtype")]
        public string SubType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        public class Balance
        {
            [JsonProperty("available")]
            public double Available { get; set; }

            [JsonProperty("current")]
            public double Current { get; set; }
        }

        public class Meta
        {
            [JsonProperty("limit")]
            public double Limit { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("number")]
            public string Number { get; set; }
        }
    }
}
