using BayonFramework.Security.Encryption.Algorithm;
using BayonFramework.Security.Encryption.Enum;
using BayonFramework.Security.Encryption.Factory;
using BayonFramework.Security.Request;

namespace BayonFramework.Security.Authentication
{
    public class AuthenticatedFiltering : AuthenticationFilterChain
    {
        private IHashAlogorithm _hashAlgorithm;

        public AuthenticatedFiltering(EncryptAlgorithm encrypt = EncryptAlgorithm.Bcrypt) {
            EncryptCreator creator = new AlgorithmCreator();
            _hashAlgorithm = creator.AlgorithmFactory(encrypt);
        }

        public override bool Handle(SecurityRequest input, out string errorMessage)
        {
            if(input is not Auth auth)
            {
                throw new InvalidOperationException("AuthenticateFilter => Error : input is not PasswordRequest");
            }
            if(!_hashAlgorithm.Verify(auth.Password, auth.HashPassword))
            {
                errorMessage = "Password: Wrong";
                return false;
            }
            errorMessage = string.Empty;
            return NextFilterChain?.Handle(input, out errorMessage) ?? true;
        }
    }
}