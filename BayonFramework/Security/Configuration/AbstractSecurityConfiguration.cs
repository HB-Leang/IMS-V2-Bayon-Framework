using BayonFramework.Security.Builder;
using BayonFramework.Security.Request;

namespace BayonFramework.Security.Configuration
{
    public abstract class AbstractSecurityConfiguration
    {
        protected SecurityRequest _securityRequest;
        protected ISecurityChain _securityChain;
        protected string? _errorMessage;

        public AbstractSecurityConfiguration(SecurityRequest securityRequest) {
            _securityRequest = securityRequest;
            _securityChain = new SecurityChain();
        }

        public string ErrorMessage
        {
            get { return _errorMessage ?? ""; }
        }

        public bool Execute()
        {
            var filter = DoFilter(_securityChain);
            if(filter.Handle(_securityRequest, out _errorMessage))
            {
                return true;
            }
            return false;
        }

        public abstract ISecurityFilterChain DoFilter(ISecurityChain securityChain);
    }
}
