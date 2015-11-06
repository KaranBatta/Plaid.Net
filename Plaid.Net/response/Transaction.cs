using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Plaid.Net.response
{
    public class Transaction
    {
        [JsonProperty("_account")]
        public string AccountId { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("meta")]
        public TransactionMeta Meta { get; set; }

        [JsonProperty("pending")]
        public bool Pending { get; set; }

        [JsonProperty("score")]
        public TransactionScore Score { get; set; }

        [JsonProperty("type")]
        public TransactionType Type { get; set; }

        [JsonProperty("type")]
        public List<string> Category { get; set; }

        [JsonProperty("category_id")]
        public double CategoryId { get; set; }

        public class TransactionType
        {
            [JsonProperty("primary")]
            public string Primary { get; set; }
        }

        public class TransactionScore
        {
            [JsonProperty("master")]
            public double Master { get; set; }

            [JsonProperty("detail")]
            public TransactionScoreDetail Detail { get; set; }
        }

        public class TransactionScoreDetail
        {
            [JsonProperty("address")]
            public double Address { get; set; }

            [JsonProperty("city")]
            public double City { get; set; }

            [JsonProperty("name")]
            public double Name { get; set; }

            [JsonProperty("state")]
            public double State { get; set; }
        }

        public class TransactionMeta
        {
            [JsonProperty("location")]
            public Location Location { get; set; }
            
            [JsonProperty("state")]
            public string State { get; set; }
            
            [JsonProperty("city")]
            public string City { get; set; }
            
            [JsonProperty("address")]
            public string Address { get; set; }
        }

        public class Location
        {
            [JsonProperty("coordinates")]
            public Coordinates Coordinates { get; set; }
        }

        public class Coordinates
        {
            [JsonProperty("lon")]
            public double Longitude { get; set; }

            [JsonProperty("lat")]
            public double Latitude { get; set; }
        }
    }
}
