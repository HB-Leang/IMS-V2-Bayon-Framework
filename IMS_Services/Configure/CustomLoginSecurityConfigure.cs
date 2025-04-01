using BayonFramework.Security;
using BayonFramework.Security.Builder;
using BayonFramework.Security.Configure;
using BayonFramework.Security.Request;

namespace IMS_Services.Configure
{
    public class CustomLoginSecurityConfigure : AbstractSecurityConfigure
    {
        public CustomLoginSecurityConfigure(SecurityRequest securityRequest) : base(securityRequest)
        {
        }

        public override ISecurityFilterChain DoFilter(ISecurityChain securityChain)
        {
            return securityChain.PasswordFilter(config => config.MinLength(6).Number())
                .Encrypt()
                .AuthFilter(config => config.AuthCheckLocked().AuthAttempt(3).Authenticated())
                .Build();
        }
    }
}
