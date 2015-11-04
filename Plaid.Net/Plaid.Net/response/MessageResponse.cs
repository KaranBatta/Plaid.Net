namespace Plaid.Net.response
{
    public class MessageResponse
    {

        private string _message;

        public string GetMessage()
        {
            return _message;
        }

        public void SetMessage(string message)
        {
            _message = message;
        }
    }
}
