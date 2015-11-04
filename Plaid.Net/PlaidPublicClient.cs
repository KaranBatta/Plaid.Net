using Plaid.Net.response;
using RestSharp;

namespace Plaid.Net
{
    public class PlaidPublicClient : IPlaidPublicClient
    {
        public RestClient Client;
        public static string BaseUriProduction = "https://api.plaid.com";
        public static string BaseUriTest = "https://tartan.plaid.com";

        private PlaidPublicClient()
        {
            Client = new RestClient(BaseUriTest);
        }

        /// <summary>
        /// esponse containing details on all Financial Institutions currently supported by Plaid.
        /// </summary>
        /// <returns></returns>
        public InstitutionsResponse GetAllInstitutions()
        {
            var request = new RestRequest("/institutions", Method.GET);
            var response = Client.Execute(request);
            return new InstitutionsResponse(response);
        }

        /// <summary>
        /// response containing all Plaid categories.
        /// Plaid category hierarchy, including category types and IDs. These category mappings are updated occasionally
        /// </summary>
        /// <returns></returns>
        public CategoriesResponse GetAllCategories()
        {
            var request = new RestRequest("/categories", Method.GET);
            var response = Client.Execute(request);
            return new CategoriesResponse(response);
        }
    }
}
