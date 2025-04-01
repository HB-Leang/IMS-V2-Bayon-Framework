using BayonFramework.Security.Encrypt.Algorithm;
using BayonFramework.Security.Encrypt.Enum;

namespace BayonFramework.Security.Encrypt.Factory
{
    public abstract class EncryptCreator
    {
        public abstract IHashAlogorithm AlgorithmFactory(EncryptAlgorithm algorithm = EncryptAlgorithm.Bcrypt);
    }
}
