using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace Plaid.Net.response
{
    public class TransactionsResponse
    {
        private readonly IRestResponse _response;

        public TransactionsResponse(IRestResponse response)
        {
            _response = response;
        }

        public List<Transaction> GetAccounts()
        {
            return JsonConvert.DeserializeObject<List<Transaction>>(_response.Content);
        }
    }
}
