namespace BayonFramework.Security.Request
{
    public class PasswordRequest : SecurityRequest
    {
        public string Password { get; set; }
        public string HashPassword { get; set; } = "";
        public PasswordRequest(string password)
        {
            this.Password = password;
        }
    }
}
