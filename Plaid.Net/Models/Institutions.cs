using System.Collections.Generic;

namespace Plaid.Net.Models
{
    public class Institutions
    {
        public string Amex { get { return "amex"; } }
        public string Bofa { get { return "bofa"; } }
        public string Capone360 { get { return "capone360"; } }
        public string Schwab { get { return "schwab"; } }
        public string Chase { get { return "chase"; } }
        public string Citi { get { return "citi"; } }
        public string Fidelity { get { return "fidelity"; } }
        public string Nfcu { get { return "nfcu"; } }
        public string Pnc { get { return "pnc"; } }
        public string Svb { get { return "svb"; } }
        public string Td { get { return "td"; } }
        public string Us { get { return "us"; } }
        public string SunTrust { get { return "suntrust"; } }
        public string Usaa { get { return "usaa"; } }
        public string Wells { get { return "wells"; } }

        //public string Value { get; set; }
        //public Institutions(string value)
        //{
        //    Value = value;
        //}
    }

    public class InstitutionCategory
    {
        private readonly Institutions _institutions;

        public InstitutionCategory(Institutions institutions)
        {
            _institutions = institutions;
        }

        public List<string> MfaInstitutions()
        {
            var list = new List<string>
            {
                _institutions.Bofa,
                _institutions.Capone360,
                _institutions.Chase,
                _institutions.Citi,
                _institutions.Pnc,
                _institutions.Td,
                _institutions.Us,
                _institutions.Usaa
            };

            return list;
        }

        public List<string> NonMfaInstitutions()
        {
            var list = new List<string>
            {
                _institutions.Wells,
                _institutions.SunTrust,
                _institutions.Svb,
                _institutions.Nfcu,
                _institutions.Fidelity,
                _institutions.Schwab,
                _institutions.Amex
            };

            return list;
        }

        public List<string> PinInstitutions()
        {
            var list = new List<string>
            {
                _institutions.Usaa
            };

            return list;
        }
    }
}
