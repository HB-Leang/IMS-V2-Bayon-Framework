using BayonFramework.Security.Request;

namespace BayonFramework.Security.RegisterFilter
{
    public class CommonPasswordFilter : RegisterFilterChain
    {
        private readonly HashSet<string> _commonPasswords;

        public CommonPasswordFilter(HashSet<string>? commonPasswords = null)
        {
            _commonPasswords = commonPasswords ?? new HashSet<string>() { "password123", "admin123", "123456", "1234", "123456789" };
        }
        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if (input is not PasswordRequest passowrdRequest)
            {
                throw new InvalidOperationException("RegisterFilter => Error : input is not PasswordRequest");
            }
            if (_commonPasswords.Contains(passowrdRequest.Password.ToLower()))
            {
                errorMessage = "Password is too common and cannot be registered";
                return false;
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}