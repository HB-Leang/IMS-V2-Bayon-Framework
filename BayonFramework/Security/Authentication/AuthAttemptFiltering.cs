using BayonFramework.Security.Request;

namespace BayonFramework.Security.Authentication
{
    public class AuthAttemptFiltering : AuthenticationFilterChain
    {
        private int _maxAttempts;

        public AuthAttemptFiltering(int maxAttempts)
        {
            _maxAttempts = maxAttempts;
        }

        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if (input is not Auth auth)
            {
                throw new InvalidOperationException("AuthAttemptFiltering => Error : input is not AuthRequest");
            }
            if(auth.Attempt > _maxAttempts)
            {
                errorMessage = $"Attempt : More Than {_maxAttempts}";
                return false;
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }

    }
}
