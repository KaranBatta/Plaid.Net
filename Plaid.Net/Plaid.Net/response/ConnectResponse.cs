using System.Collections.Generic;

namespace Plaid.Net.response
{
    public class ConnectResponse /*: AccountsResponse */
    {
        protected List<Transaction> Transactions;

        public List<Transaction> GetTransactions()
        {
            return Transactions;
        }

        public void SetTransactions(List<Transaction> transactions)
        {
            Transactions = transactions;
        }
    }
}
