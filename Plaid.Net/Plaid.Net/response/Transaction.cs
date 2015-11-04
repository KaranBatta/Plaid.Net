using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Plaid.Net.response
{
    public class Transaction
    {

        [JsonProperty("_id")]
        private string _id;

        [JsonProperty("_account")]
        private string _accountId;

        [JsonProperty("_entity")]
        private string _entityId;

        [JsonProperty("category_id")]
        private string _categoryId;

        [JsonProperty("_pendingTransaction")]
        private string _pendingTransactionId;

        private string _name;
        private List<string> _category;
        private double _amount;
        private DateTime _date;
        private Dictionary<string, string> _type;

        private Score _score;
        private TransactionMeta _meta;

        private bool _pending;

        public string GetId()
        {
            return _id;
        }

        public void SetId(string id)
        {
            _id = id;
        }

        public string GetAccountId()
        {
            return _accountId;
        }

        public void SetAccountId(string accountId)
        {
            _accountId = accountId;
        }

        public string GetEntityId()
        {
            return _entityId;
        }

        public void SetEntityId(string entityId)
        {
            _entityId = entityId;
        }

        public string GetCategoryId()
        {
            return _categoryId;
        }

        public void SetCategoryId(string categoryId)
        {
            _categoryId = categoryId;
        }

        public string GetPendingTransactionId()
        {
            return _pendingTransactionId;
        }

        public void SetPendingTransactionId(string pendingTransactionId)
        {
            _pendingTransactionId = pendingTransactionId;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public List<string> GetCategory()
        {
            return _category;
        }

        public void SetCategory(List<string> category)
        {
            _category = category;
        }

        public double GetAmount()
        {
            return _amount;
        }

        public void SetAmount(double amount)
        {
            _amount = amount;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public void SetDate(DateTime date)
        {
            _date = date;
        }

        public Dictionary<string, string> GetType()
        {
            return _type;
        }

        public void SetType(Dictionary<string, string> type)
        {
            _type = type;
        }

        public Score GetScore()
        {
            return _score;
        }

        public void SetScore(Score score)
        {
            _score = score;
        }

        public TransactionMeta GetMeta()
        {
            return _meta;
        }

        public void SetMeta(TransactionMeta meta)
        {
            _meta = meta;
        }

        public bool IsPending()
        {
            return _pending;
        }

        public void SetPending(bool pending)
        {
            _pending = pending;
        }

        public class Score
        {
            private double _master;
            private Dictionary<string, double> _detail;

            public double GetMaster()
            {
                return _master;
            }

            public void SetMaster(double master)
            {
                _master = master;
            }

            public Dictionary<string, double> GetDetail()
            {
                return _detail;
            }

            public void SetDetail(Dictionary<string, double> detail)
            {
                _detail = detail;
            }
        }

        public class TransactionMeta
        {
            private Location _location;
            private Dictionary<string, string> _contact;
            private Dictionary<string, string> _ids;

            public Location GetLocation()
            {
                return _location;
            }

            public void SetLocation(Location location)
            {
                _location = location;
            }

            public Dictionary<string, string> GetContact()
            {
                return _contact;
            }

            public void SetContact(Dictionary<string, string> contact)
            {
                _contact = contact;
            }

            public Dictionary<string, string> GetIds()
            {
                return _ids;
            }

            public void SetIds(Dictionary<string, string> ids)
            {
                _ids = ids;
            }
        }

        public class Location
        {
            private Coordinates _coordinates;
            private string _zip;
            private string _state;
            private string _city;
            private string _address;

            public Coordinates GetCoordinates()
            {
                return _coordinates;
            }

            public void SetCoordinates(Coordinates coordinates)
            {
                _coordinates = coordinates;
            }

            public string GetZip()
            {
                return _zip;
            }

            public void SetZip(string zip)
            {
                _zip = zip;
            }

            public string GetState()
            {
                return _state;
            }

            public void SetState(string state)
            {
                _state = state;
            }

            public string GetCity()
            {
                return _city;
            }

            public void SetCity(string city)
            {
                _city = city;
            }

            public string GetAddress()
            {
                return _address;
            }

            public void SetAddress(string address)
            {
                _address = address;
            }
        }

        public class Coordinates
        {
            [JsonProperty("lon")]
            private double _longitude;

            [JsonProperty("lat")]
            private double _latitude;

            public Double GetLongitude()
            {
                return _longitude;
            }

            public void SetLongitude(Double longitude)
            {
                _longitude = longitude;
            }

            public Double GetLatitude()
            {
                return _latitude;
            }

            public void SetLatitude(Double latitude)
            {
                _latitude = latitude;
            }
        }
    }
}
