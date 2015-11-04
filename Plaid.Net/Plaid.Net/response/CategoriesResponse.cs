using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace Plaid.Net.response
{
   public class CategoriesResponse
    {
        private readonly IRestResponse _response;

        public CategoriesResponse(IRestResponse response)
        {
            _response = response;
        }

       public List<Category> GetCategories()
       {
           return JsonConvert.DeserializeObject<List<Category>>(_response.Content);
       }
    }
}
