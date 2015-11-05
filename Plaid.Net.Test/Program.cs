namespace Plaid.Net.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetAllInstitutions();
        }

        public static void GetAllInstitutions()
        {
            var plaidPublicClient = new PlaidPublicClient();
            var response = plaidPublicClient.GetAllInstitutions();
            var institutions = response.GetInstitutions();
        }
    }
}
