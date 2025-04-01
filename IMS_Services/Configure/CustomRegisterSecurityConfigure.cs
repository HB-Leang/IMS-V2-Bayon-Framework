﻿using BayonFramework.Security;
using BayonFramework.Security.Builder;
using BayonFramework.Security.Configure;
using BayonFramework.Security.Request;

namespace IMS_Services.Configure
{
    public class CustomRegisterSecurityConfigure : AbstractSecurityConfigure
    {
        public CustomRegisterSecurityConfigure(SecurityRequest securityRequest) : base(securityRequest)
        {
        }

        public override ISecurityFilterChain DoFilter(ISecurityChain securityChain)
        {
            return securityChain.PasswordFilter(config =>
                    config.MinLength(6)
                    .Number()
                    .NoSpaces()
                )
                .Encrypt()
                .RegisterFilter(config => config.CommonPassword())
                .Build();
        }
    }
}
