using BayonFramework.Security.Authentication;

namespace BayonFramework.Security.Builder.Configure
{
    public class AuthBuilderConfigure
    {
        private readonly List<AuthenticationFilterChain> _filters = new List<AuthenticationFilterChain>();
        private readonly SecurityChain _securityChain;

        public AuthBuilderConfigure(SecurityChain securityChain)
        {
            _securityChain = securityChain;
        }

        public AuthBuilderConfigure AuthAttempt(int _maxAttempt)
        {
            _filters.Add(new AuthAttemptFiltering(_maxAttempt));
            return this;
        }
        
        public AuthBuilderConfigure AuthCheckLocked()
        {
            _filters.Add(new AuthLockFiltering());
            return this;
        }

        public AuthBuilderConfigure Authenticated()
        {
            _filters.Add(new AuthenticatedFiltering(_securityChain._encryptAlgorithm));
            return this;
        }

        public SecurityChain Auth()
        {
            _securityChain.DoAddAuthFiltering(_filters);
           return _securityChain;
        }
    }
}
