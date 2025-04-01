using BayonFramework.Security.Request;

namespace BayonFramework.Security
{
    public interface ISecurityFilterChain
    {
        void NextFilter(ISecurityFilterChain next);
        bool Handle(SecurityRequest input, out string errorMessage);
    }
}
