using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace Plaid.Net.response
{
    public class AccountsResponse
    {
        private readonly IRestResponse _response;

        public AccountsResponse(IRestResponse response)
        {
            _response = response;
        }

        public List<Account> GetAccounts()
        {
            return JsonConvert.DeserializeObject<List<Account>>(_response.Content);
        }
    }
}
