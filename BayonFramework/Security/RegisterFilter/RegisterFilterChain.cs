using BayonFramework.Security.Request;

namespace BayonFramework.Security.RegisterFilter
{
    public abstract class RegisterFilterChain : ISecurityFilterChain
    {
        protected ISecurityFilterChain? NextFilterChain;
        public abstract bool Handle(SecurityRequest input, out string errorMessage);
        public void NextFilter(ISecurityFilterChain next)
        {
            NextFilterChain = next;
        }
    }
}
