using Newtonsoft.Json;

namespace Plaid.Net.request
{
    public class ConnectOptions
    {
        public ConnectOptions(bool loginOnly)
        {
            LoginOnly = loginOnly;
        }

        public ConnectOptions(bool pending, string startDate, string endDate)
        {
            Pending = pending;
            StartDate = startDate;
            EndDate = endDate;
        }

        public ConnectOptions(string webhook, bool pending, bool loginOnly, bool list, string startDate, string endDate)
        {
            Webhook = webhook;
            Pending = pending;
            LoginOnly = loginOnly;
            List = list;
            StartDate = startDate;
            EndDate = endDate;
        }

        /// <summary>
        /// default is null only relevant if login_only is true This webhook will be hit when the users' transactions have finished processing. See webhook.
        /// </summary>
        [JsonProperty("webhook")]
        public string Webhook { get; set; }

        /// <summary>
        /// default is false If set to true, pending transactions will be returned. 
        /// Pending transactions will generally show up as posted within one to three business days, depending on the type of transaction
        ///  - though some transactions may never post. Currently, new transaction IDs will be generated for all posted transactions.
        /// </summary>
        [JsonProperty("pending")]
        public bool Pending { get; set; }

        /// <summary>
        /// default is false This option is valid for the initial authentication only. 
        /// If set to false, the initial /connect request will return transaction data based on the start_date and end_date specified.
        /// </summary>
        [JsonProperty("login_only")]        
        public bool LoginOnly { get; set; }
        
        /// <summary>
        /// default is false If the institution requires a code-based MFA credential,
        /// this option will list the available send methods. For example, Email (ex a...z@plaid.com), Text (ex 123-...-4321).
        /// See Code-Based MFA for more details.
        /// </summary>
        [JsonProperty("list")]        
        public bool List { get; set; }
        
        /// <summary>
        /// default is 30 days The start date from which to return transactions.
        /// Dates are interpreted using Sugar and can take the form of: '10 days ago', '09/21/2012', etc.
        /// It is strongly recommended that you do not pull more than 60 days.
        /// </summary>
        [JsonProperty("start_date")]        
        public string StartDate { get; set; }
        
        /// <summary>
        /// default is today The end date to which transactions will be collected.
        /// </summary>
        [JsonProperty("end_date")]        
        public string EndDate { get; set; }
    }
}
