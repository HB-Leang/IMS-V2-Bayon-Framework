using BayonFramework.Security.Encryption.Algorithm;
using BayonFramework.Security.Encryption.Enum;

namespace BayonFramework.Security.Encryption.Factory
{
    public abstract class EncryptCreator
    {
        public abstract IHashAlogorithm AlgorithmFactory(EncryptAlgorithm algorithm = EncryptAlgorithm.Bcrypt);
    }
}
