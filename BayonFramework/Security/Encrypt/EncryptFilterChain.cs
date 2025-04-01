using BayonFramework.Security.Encrypt.Algorithm;
using BayonFramework.Security.Encrypt.Enum;
using BayonFramework.Security.Encrypt.Factory;
using BayonFramework.Security.Request;

namespace BayonFramework.Security.Encrypt
{
    public class EncryptFilterChain : ISecurityFilterChain
    {
        private ISecurityFilterChain? NextFilterChain;
        private readonly IHashAlogorithm _hashAlogorithm;

        public EncryptFilterChain(EncryptAlgorithm encrypt = EncryptAlgorithm.Bcrypt)
        {
            _hashAlogorithm = new AlgorithmCreator().AlgorithmFactory(encrypt);
        }

        public bool Handle(SecurityRequest input, out string errorMessage)
        {
            if (input is not PasswordRequest passwordRequest) {
                throw new InvalidOperationException("EncryptFilterChain => Error : input is not PasswordRequest");
            }
            try
            {
                passwordRequest.HashPassword = _hashAlogorithm.HashPassword(passwordRequest.Password);
                errorMessage =  string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Failed to hash password: {ex.Message}";
                return false;
            }
        }

        public void NextFilter(ISecurityFilterChain next)
        {
            NextFilterChain = next;
        }
    }
}
