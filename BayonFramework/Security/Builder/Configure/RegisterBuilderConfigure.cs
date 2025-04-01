
using BayonFramework.Security.PasswordFilter;
using BayonFramework.Security.RegisterFilter;

namespace BayonFramework.Security.Builder.Configure
{
    public class RegisterBuilderConfigure
    {
        private readonly List<RegisterFilterChain> _filters = new List<RegisterFilterChain>();
        private readonly SecurityChain _securityChain;

        public RegisterBuilderConfigure(SecurityChain securityChainBuilder)
        {
            _securityChain = securityChainBuilder;
        }

        public RegisterBuilderConfigure CommonPassword(HashSet<string>? rule = null)
        {
            _filters.Add(new CommonPasswordFilter(rule));
            return this;
        }

        public SecurityChain Regiter()
        {
            _securityChain.DoAddRegisterFiltering(_filters);
            return _securityChain;
        }
    }
}
