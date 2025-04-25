using BayonFramework.Security.Builder.Configure;
using BayonFramework.Security.Encryption.Algorithm;
using BayonFramework.Security.Encryption.Enum;

namespace BayonFramework.Security.Builder
{
    public interface ISecurityChain
    {
        ISecurityFilterChain Build();
        public ISecurityChain BasicPassword();
        public ISecurityChain StrongPassword();
        public ISecurityChain PasswordFilter(Action<PasswordBuilderConfigure> configure);
        public ISecurityChain RegisterFilter(Action<RegisterBuilderConfigure> configure);
        public ISecurityChain AuthFilter(Action<AuthBuilderConfigure> configure);
        public ISecurityChain Encrypt(EncryptAlgorithm encryptAlgorithm = EncryptAlgorithm.Bcrypt);
    }
}