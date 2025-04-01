using BCrypt.Net;

namespace BayonFramework.Security.Encrypt.Algorithm
{
    public class BcryptAlgorithm : IHashAlogorithm
    {
        public string HashPassword(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        public bool Verify(string plainPassword, string hashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashPassword);
        }
    }
}
