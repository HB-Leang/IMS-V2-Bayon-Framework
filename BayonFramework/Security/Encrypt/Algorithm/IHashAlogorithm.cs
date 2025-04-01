namespace BayonFramework.Security.Encrypt.Algorithm
{
    public interface IHashAlogorithm
    {
        string HashPassword(string plainPassword);
        bool Verify(string plainPassword, string hashPassword);
    }
}
