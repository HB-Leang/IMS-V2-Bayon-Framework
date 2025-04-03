using BayonFramework.Security;
using BayonFramework.Security.Builder;
using BayonFramework.Security.Configuration;
using BayonFramework.Security.Request;

namespace IMS_Services.SecurityConfig
{
    public class CustomLoginSecurityConfiguration : AbstractSecurityConfiguration
    {
        public CustomLoginSecurityConfiguration(SecurityRequest securityRequest) : base(securityRequest)
        {
        }

        public override ISecurityFilterChain DoFilter(ISecurityChain securityChain)
        {
            return securityChain
                .BasicPassword()
                .Encrypt()
                .AuthFilter(config => config.AuthCheckLocked().AuthAttempt(3).Authenticated())
                .Build();
        }
    }
}
