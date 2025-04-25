using BayonFramework.Security.Request;

namespace BayonFramework.Security.PasswordFilter.Rule
{
    public class UppercaseFilter : PasswordFilterChain
    {
        public override bool Handle(SecurityRequest input, out string errorMessage)
        {

            if (input is not PasswordRequest passowrdRequest)
            {
                throw new InvalidOperationException("UppercaseFilter => Error : input is not PasswordRequest");
            }
            if (!passowrdRequest.Password.Any(char.IsUpper))
            {
                errorMessage = "Password must contain at least one uppercase letter";
                return false;
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}
