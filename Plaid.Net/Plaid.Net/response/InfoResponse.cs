using System.Collections.Generic;
using Newtonsoft.Json;

namespace Plaid.Net.response
{
    //public class InfoResponse : PlaidUserResponse {

    //    private List<Account> _accounts;
    //    private Info _info;
	
    //    public List<Account> GetAccounts() {
    //        return _accounts;
    //    }

    //    public void SetAccounts(List<Account> accounts) {
    //        _accounts = accounts;
    //    }

    //    public Info GetInfo() {
    //        return _info;
    //    }

    //    public void SetInfo(Info info) {
    //        _info = info;
    //    }

    //    public class Info {

    //        private List<string> _names;
    //        private List<Email> _emails;

    //        [JsonProperty("phone_numbers")]
    //        private List<PhoneNumber> _phoneNumbers;
    //        private List<Address> _addresses;

    //        public List<string> GetNames() {
    //            return _names;
    //        }
    //        public void SetNames(List<string> names) {
    //            _names = names;
    //        }
    //        public List<Email> GetEmails() {
    //            return _emails;
    //        }
    //        public void SetEmails(List<Email> emails) {
    //            _emails = emails;
    //        }

    //        public List<PhoneNumber> GetPhoneNumbers() {
    //            return _phoneNumbers;
    //        }
    //        public void SetPhoneNumbers(List<PhoneNumber> phoneNumbers) {
    //            this._phoneNumbers = phoneNumbers;
    //        }
    //        public List<Address> GetAddresses() {
    //            return _addresses;
    //        }
    //        public void SetAddresses(List<Address> addresses) {
    //            _addresses = addresses;
    //        }
    //    } 

    //    public class Email {

    //        private string _data;
    //        private string _type;
		
    //        public string GetData() {
    //            return _data;
    //        }
    //        public void SetData(string data) {
    //            _data = data;
    //        }
    //        public string GetType() {
    //            return _type;
    //        }
    //        public void SetType(string type) {
    //            _type = type;
    //        }		
    //    }

    //    public class PhoneNumber {

    //        private string _data;
    //        private string _type;
    //        private bool _primary;
		
    //        public string GetData() {
    //            return _data;
    //        }
    //        public void SetData(string data) {
    //            _data = data;
    //        }
    //        public string GetType() {
    //            return _type;
    //        }
    //        public void SetType(string type) {
    //            _type = type;
    //        }
    //        public bool IsPrimary() {
    //            return _primary;
    //        }
    //        public void SetPrimary(bool primary) {
    //            _primary = primary;
    //        }		
    //    }

    //    public class Address {

    //        private bool _primary;

    //        [JsonProperty("address")]
    //        private AddressDetails _addressDetails;
		
    //        public bool GetPrimary() {
    //            return _primary;
    //        }

    //        public void SetPrimary(bool primary) {
    //            _primary = primary;
    //        }

    //        public AddressDetails GetAddressDetails() {
    //            return _addressDetails;
    //        }

    //        public void SetAddressDetails(AddressDetails addressDetails) {
    //            _addressDetails = addressDetails;
    //        }	
    //    }

    //    public class AddressDetails {

    //        private string _street;
    //        private string _city;
    //        private string _state;
    //        private string _zip;
		
    //        public string GetStreet() {
    //            return _street;
    //        }

    //        public void SetStreet(string street) {
    //            _street = street;
    //        }

    //        public string GetCity() {
    //            return _city;
    //        }

    //        public void SetCity(string city) {
    //            _city = city;
    //        }

    //        public string GetState() {
    //            return _state;
    //        }

    //        public void SetState(string state) {
    //            _state = state;
    //        }

    //        public string GetZip() {
    //            return _zip;
    //        }

    //        public void SetZip(string zip) {
    //            _zip = zip;
    //        }		
    //    }
    //}
}
