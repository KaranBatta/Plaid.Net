namespace Plaid.Net.response
{
    public class ErrorResponse
    {
        private int _code;
        private string _message;
        private string _resolve;

        public int GetCode()
        {
            return _code;
        }
        public void SetCode(int code)
        {
            _code = code;
        }
        public string GetMessage()
        {
            return _message;
        }
        public void SetMessage(string message)
        {
            _message = message;
        }
        public string GetResolve()
        {
            return _resolve;
        }
        public void SetResolve(string resolve)
        {
            _resolve = resolve;
        }
    }
}
