using BayonFramework.Security;
using BayonFramework.Security.Builder;
using BayonFramework.Security.Configuration;
using BayonFramework.Security.Request;

namespace IMS_Services.SecurityConfig
{
    public class CustomRegisterSecurityConfiguration : AbstractSecurityConfiguration
    {
        public CustomRegisterSecurityConfiguration(SecurityRequest securityRequest) : base(securityRequest)
        {
        }

        public override ISecurityFilterChain DoFilter(ISecurityChain securityChain)
        {
            return securityChain
                .BasicPassword()
                .Encrypt()
                .RegisterFilter(config => config.CommonPassword())
                .Build();
        }

    }
}
