using System;
using Newtonsoft.Json;

namespace Plaid.Net.response
{
    public class Account
    {
        [JsonProperty("_id")]
        private String _id;
        
        [JsonProperty("_item")]
        private String _item;

        [JsonProperty("_user")]
        private String _userId;

        private Balance _balance;
        private AccountMeta _meta;
        private AccountNumbers _numbers;

        [JsonProperty("institution_type")]
        private String _institutionType;

        private String _type;
        private String _subtype;
 
        public String GetId()
        {
            return _id;
        }

        public void SetId(String id)
        {
            _id = id;
        }

        public String GetItem()
        {
            return _item;
        }

        public void SetItem(String item)
        {
            _item = item;
        }

        public String GetUserId()
        {
            return _userId;
        }

        public void SetUserId(String userId)
        {
            _userId = userId;
        }

        public Balance GetBalance()
        {
            return _balance;
        }

        public void SetBalance(Balance balance)
        {
            _balance = balance;
        }

        public AccountMeta GetMeta()
        {
            return _meta;
        }

        public void SetMeta(AccountMeta meta)
        {
            _meta = meta;
        }

        public AccountNumbers GetNumbers()
        {
            return _numbers;
        }

        public void SetNumbers(AccountNumbers numbers)
        {
            _numbers = numbers;
        }

        public String GetInstitutionType()
        {
            return _institutionType;
        }

        public void SetInstitutionType(String institutionType)
        {
            _institutionType = institutionType;
        }

        public String GetType()
        {
            return _type;
        }

        public void SetType(String type)
        {
            _type = type;
        }

        public String GetSubtype()
        {
            return _subtype;
        }

        public void DetSubtype(String subtype)
        {
            _subtype = subtype;
        }

        public class Balance
        {
            private Double _available;
            private Double _current;

            public Double GetAvailable()
            {
                return _available;
            }

            public void SetAvailable(Double available)
            {
                _available = available;
            }

            public Double GetCurrent()
            {
                return _current;
            }

            public void SetCurrent(Double current)
            {
                _current = current;
            }
        }

        public class AccountMeta
        {
            private Double _limit;
            private String _name;
            private String _number;

            public Double GetLimit()
            {
                return _limit;
            }

            public void SetLimit(Double limit)
            {
                _limit = limit;
            }

            public String GetName()
            {
                return _name;
            }

            public void SetName(String name)
            {
                _name = name;
            }

            public String GetNumber()
            {
                return _number;
            }

            public void SetNumber(String number)
            {
                _number = number;
            }
        }

        public class AccountNumbers
        {
            private String _routing;
            private String _account;
            private String _wireRouting;

            public String GetRouting()
            {
                return _routing;
            }

            public void SetRouting(String routing)
            {
                this._routing = routing;
            }

            public String GetAccount()
            {
                return _account;
            }

            public void SetAccount(String account)
            {
                _account = account;
            }

            public String GetWireRouting()
            {
                return _wireRouting;
            }

            public void SetWireRouting(String wireRouting)
            {
                _wireRouting = wireRouting;
            }
        }
    }
}
