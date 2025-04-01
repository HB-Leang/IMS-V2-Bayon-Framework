namespace BayonFramework.Security.Request
{
    public class Auth : PasswordRequest, SecurityRequest
    {
        public string UserName { get; set; }
        public int Attempt { get; set; }
        public DateTime LockTime { get; set; }
        public bool Locked { get; set; }
        public Auth(string username, string password) : base(password)
        {
            UserName = username;
        }
    }
}
