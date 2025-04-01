using BayonFramework.Security;
using BayonFramework.Security.Builder;
using BayonFramework.Security.Configure;
using BayonFramework.Security.Request;

namespace BayonFramework
{
    public class CustomSecurityConfigure : AbstractSecurityConfigure
    {
        public CustomSecurityConfigure(SecurityRequest securityRequest) : base(securityRequest)
        {
        }
        public override ISecurityFilterChain DoFilter(ISecurityChain securityChain)
        {
            return securityChain.PasswordFilter(request => request.MinLength(6).Number()).Build();
        }
    }
}
