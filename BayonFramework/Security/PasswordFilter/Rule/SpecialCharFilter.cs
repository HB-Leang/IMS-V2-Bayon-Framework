using BayonFramework.Security.Request;

namespace BayonFramework.Security.PasswordFilter.Rule
{
    public class SpecialCharFilter : PasswordFilterChain
    {
        private readonly char[] _specialChars;

        public SpecialCharFilter(char[]? specialChars = null)
        {
            _specialChars = specialChars ?? new char[] { '!', '@', '#', '$', '%', '^', '&', '*' };
        }

        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if (input is not PasswordRequest passowrdRequest)
            {
                throw new InvalidOperationException("SpecialCharFilter => Error : input is not PasswordRequest");
            }
            if (!passowrdRequest.Password.Any(ch => _specialChars.Contains(ch)))
            {
                errorMessage = $"Password must contain at least one special character ({string.Join("", _specialChars)})";
                return false;
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}
