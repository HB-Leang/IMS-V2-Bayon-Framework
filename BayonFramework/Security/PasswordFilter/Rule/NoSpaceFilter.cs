using BayonFramework.Security.Request;


namespace BayonFramework.Security.PasswordFilter.Rule
{
    public class NoSpaceFilter : PasswordFilterChain
    {
        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if (input is not PasswordRequest passowrdRequest)
            {
                throw new InvalidOperationException("NoSpaceFilter => Error : input is not PasswordRequest");
            }
            if (passowrdRequest.Password.Contains(" "))
            {
                errorMessage = "Password cannot contain spaces";
                return false;
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}
