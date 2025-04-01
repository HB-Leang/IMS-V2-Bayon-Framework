using BayonFramework.Security.Request;

namespace BayonFramework.Security.PasswordFilter
{
    public abstract class PasswordFilterChain : ISecurityFilterChain
    {
        protected ISecurityFilterChain? NextFilterChain;
        public abstract bool Handle(SecurityRequest input, out string errorMessage);
        public void NextFilter(ISecurityFilterChain next)
        {
            NextFilterChain = next;
        }
    }
}