using System.Runtime;
using Plaid.Net.Models;
using RestSharp;

namespace Plaid.Net.response
{
    public class ConnectResponse
    {
        private IRestResponse _response;
        private readonly string _type;

        public ConnectResponse(string type, IRestResponse response)
        {
            _response = response;
            _type = type;
        }

        public void GetResponse()
        {
            var institutions = new InstitutionCategory(new Institutions());
            foreach (var inst in institutions.MfaInstitutions())
            {
                if (_type.Equals(inst))
                {
                    return MfaInfo();
                }
            }
        }

        public Accounts AccountList()
        {
            
        }

        public MfaStep MfaInfo()
        {
            
        }
    }
}
