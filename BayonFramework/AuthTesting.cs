using BayonFramework.Security.Request;
using BayonFramework.Security;
using BayonFramework.Security.PasswordFilter.Rule;
using BayonFramework.Security.Builder;

namespace BayonFramework
{
    public class AuthTesting
    {

        public static void Run()
        {
            SimpleTest();
            //RegisterTest();
            //LoginTest();


            /* Chain Responsibility Encrpty and Register Builder */

            //var security2 = new SecurityChain()
            //    .PasswordFilter(config => config.MinLength(6).Number().NoSpaces())
            //    .Encrypt(EncryptAlgorithm.SHA2)
            //    .RegisterFilter(config => config.CommonPassword())
            //    .Build();

            //var password2 = new PasswordRequest("admin1234");

            //TestPassword(security2, password2);

            //Console.WriteLine($"{password2.Password} - {password2.HashPassword}");
        }

        private static void LoginTest()
        {

        }

        private static void RegisterTest()
        {

        }

        private static void SimpleTest()
        {
            Auth auth = new AuthRequest("piko", "piko").Build();

            /* Chain Responsibility With Builder */

            var security = new SecurityChain()
                .PasswordFilter(request => request.MinLength(6).Number())
                .Build();

            Console.WriteLine(security);

            TestPassword(security, auth);
        }

        static void TestPassword(ISecurityFilterChain securityFilterChain,SecurityRequest request)
        {
            if (securityFilterChain.Handle(request, out string error))
            {
                Console.WriteLine($"Password is valid");
            }
            else
            {
                Console.WriteLine($"Password is invalid: {error}");
            }
        }
    }
}
