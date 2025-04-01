using BayonFramework.Security.Request;

namespace BayonFramework.Security.PasswordFilter.Rule
{
    public class LengthFilter : PasswordFilterChain
    {
        private readonly int _minLength;

        public LengthFilter(int minLenght)
        {
            _minLength = minLenght;
        }

        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if (input is not PasswordRequest passowrdRequest)
            {
                throw new InvalidOperationException("LengthFilter => Error : input is not PasswordRequest");
            }
            if (string.IsNullOrEmpty(passowrdRequest.Password) || passowrdRequest.Password.Length < _minLength)
            {
                errorMessage = $"Password must be at least {this._minLength} characters long";
                return false;
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}
