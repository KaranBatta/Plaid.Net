using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace Plaid.Net.response
{
    public class InstitutionsResponse
    {
        private readonly IRestResponse _response;

        public InstitutionsResponse(IRestResponse response)
        {
            _response = response;
        }

        public List<Institution> GetInstitutions()
        {
            return JsonConvert.DeserializeObject<List<Institution>>(_response.Content);
        }
    }
}
