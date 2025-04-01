using BayonFramework.Security.Request;


namespace BayonFramework.Security.PasswordFilter.Rule
{
    public class NumberFilter : PasswordFilterChain
    {
        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if (input is not PasswordRequest passowrdRequest)
            {
                throw new InvalidOperationException("NumberFilter => Error : input is not PasswordRequest");
            }
            if (!passowrdRequest.Password.Any(char.IsDigit))
            {
                errorMessage = "Password must contain at least one number";
                return false;
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}
