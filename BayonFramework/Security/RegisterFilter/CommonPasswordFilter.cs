using BayonFramework.Security.Request;
using System.Net.Sockets;

namespace BayonFramework.Security.RegisterFilter
{
    public class CommonPasswordFilter : RegisterFilterChain
    {
        private readonly HashSet<string> _commonPasswords;
        public CommonPasswordFilter(HashSet<string>? commonPasswords = null)
        {
            _commonPasswords = commonPasswords ?? new HashSet<string>() {
                "123456",
                "123456789",
                "12345678",
                "password",
                "qwerty123",
                "qwerty1",
                "111111",
                "12345",
                "secret",
                "123123",
                "abc123",
                "password1",
                "letmein",
                "q2w3e4r",
                "monkey",
                "qwerty",
                "123qwe",
                "1234",
                "iloveyou",
                "123321"
            };
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