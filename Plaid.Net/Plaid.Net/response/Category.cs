using System.Collections.Generic;
using Newtonsoft.Json;

namespace Plaid.Net.response
{
    public class Category {

        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("hierarchy")]
        public List<string> Hierarchy { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }
    }
}
