using BayonFramework.Security.Request;

namespace BayonFramework.Security.Authentication
{
    public class AuthLockFiltering : AuthenticationFilterChain
    {
        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if (input is not  Auth auth)
            {
                throw new InvalidOperationException("AuthLockFiltering => Error : input is not AuthRequest");
            }
            if (auth.Locked)
            {
                errorMessage = "Credential Has Been Locked ! Please Contect Admin To UnLock";
                return false;
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}
