
using BayonFramework.Security.Encrypt.Algorithm;
using BayonFramework.Security.Encrypt.Enum;

namespace BayonFramework.Security.Encrypt.Factory
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
