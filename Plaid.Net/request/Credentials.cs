namespace Plaid.Net.request
{
    public class Credentials
    {
        public Credentials(string username, string password, string pin)
        {
            UserName = username;
            Password = password;
            Pin = pin;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
    }
}
