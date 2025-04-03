
using BayonFramework.Security.Encryption.Algorithm;
using BayonFramework.Security.Encryption.Enum;

namespace BayonFramework.Security.Encryption.Factory
{
    public class AlgorithmCreator : EncryptCreator
    {
        public override IHashAlogorithm AlgorithmFactory(EncryptAlgorithm algorithm = EncryptAlgorithm.Bcrypt)
        {
            if (algorithm.Equals(EncryptAlgorithm.Bcrypt))
            {
                return new BcryptAlgorithm();
            }
            return new SHA2Algorithm();
        }
    }
}
