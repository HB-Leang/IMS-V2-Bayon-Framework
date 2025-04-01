using BayonFramework.Security.Encrypt.Algorithm;
using BayonFramework.Security.Encrypt.Enum;
using BayonFramework.Security.Encrypt.Factory;
using BayonFramework.Security.Request;

namespace BayonFramework.Security.Authentication
{
    public class AuthenticatedFiltering : AuthenticationFilterChain
    {
        private EncryptAlgorithm _encryptAlgorithm;
        private IHashAlogorithm _algorithm;
        
        public AuthenticatedFiltering(EncryptAlgorithm encrypt = EncryptAlgorithm.Bcrypt) {
            _encryptAlgorithm = encrypt;
            _algorithm = new AlgorithmCreator().AlgorithmFactory(encrypt);
        }

        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if(input is not Auth auth)
            {
                throw new InvalidOperationException("AuthenticateFilter => Error : input is not PasswordRequest");
            }
            if(!_algorithm.Verify(auth.Password, auth.HashPassword))
            {
                errorMessage = "Password Wrong";
                return false;
            }

            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}
