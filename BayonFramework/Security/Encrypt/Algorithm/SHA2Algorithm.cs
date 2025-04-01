using System.Security.Cryptography;

namespace BayonFramework.Security.Encrypt.Algorithm
{
    public class SHA2Algorithm : IHashAlogorithm
    {
        public string HashPassword(string plainPassword)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(plainPassword);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public bool Verify(string plainPassword, string hashPassword)
        {
            string newHash = HashPassword(plainPassword);
            return newHash.Equals(hashPassword);
        }
    }
}