using BayonFramework.Security.Request;
using BayonFramework.Security;
using BayonFramework.Security.PasswordFilter.Rule;
using BayonFramework.Security.Builder;
using BayonFramework.Security.Encrypt.Enum;

namespace BayonFramework
{
    public class AuthTesting
    {

        public static void Run()
        {
            //SimpleTest();
            //RegisterTest();
            //LoginTest();

        }

        private static void LoginTest()
        {
            Auth test1 = new AuthRequest("piko", "piko123456")
                .WithLocked(false)
                .WithAttempt(0)
                .WithHashPassword("$2a$11$yHpgFMHKJQtfTd/CaIFp2.vh54Dwldlah1jYkHu7/HHuS4SDLueO2")
                .Build();

            Auth test2 = new AuthRequest("piko", "piko23456")
                .WithLocked(false)
                .WithAttempt(0)
                .WithHashPassword("$2a$11$yHpgFMHKJQtfTd/CaIFp2.vh54Dwldlah1jYkHu7/HHuS4SDLueO2")
                .Build();

            Auth test3 = new AuthRequest("piko", "piko123456")
                .WithLocked(true)
                .WithAttempt(0)
                .WithHashPassword("$2a$11$yHpgFMHKJQtfTd/CaIFp2.vh54Dwldlah1jYkHu7/HHuS4SDLueO2")
                .Build();

            Auth test4 = new AuthRequest("piko", "piko123456")
                .WithLocked(false)
                .WithAttempt(4)
                .WithHashPassword("$2a$11$yHpgFMHKJQtfTd/CaIFp2.vh54Dwldlah1jYkHu7/HHuS4SDLueO2")
                .Build();

            var security = new SecurityChain()
                .PasswordFilter(config => config.MinLength(6).Number())
                .Encrypt()
                .AuthFilter(config => config.AuthCheckLocked().AuthAttempt(3).Authenticated())
                .Build();

            TestPassword(security, test1);
            Console.WriteLine($"{test1.Password} - {test1.HashPassword}");

            TestPassword(security, test2);
            Console.WriteLine($"{test2.Password} - {test2.HashPassword}");

            TestPassword(security, test3);
            TestPassword(security, test4);
        }

        private static void RegisterTest()
        {

            Auth test1 = new AuthRequest("piko", "piko123456").Build(); // $2a$11$yHpgFMHKJQtfTd/CaIFp2.vh54Dwldlah1jYkHu7/HHuS4SDLueO2
            Auth test2 = new AuthRequest("piko", "piko 123456").Build();
            Auth test3 = new AuthRequest("piko", "admin123").Build();

            /* Chain Responsibility Encrpty and Register Builder */

            var security = new SecurityChain()
                .PasswordFilter(config => 
                    config.MinLength(6)
                    .Number()
                    .NoSpaces()
                )
                .Encrypt()
                .RegisterFilter(config => config.CommonPassword())
                .Build();

            TestPassword(security, test1);
            Console.WriteLine($"{test1.Password} - {test1.HashPassword}");

            TestPassword(security, test2);
            Console.WriteLine($"{test2.Password} - {test2.HashPassword}");

            TestPassword(security, test3);
            Console.WriteLine($"{test3.Password} - {test3.HashPassword}");
        }

        private static void SimpleTest()
        {
            Auth test1 = new AuthRequest("piko", "piko").Build();
            Auth test2 = new AuthRequest("piko", "piko12345").Build();

            /* Chain Responsibility With Builder */

            var security = new SecurityChain()
                .PasswordFilter(request => request.MinLength(6).Number())
                .Build();

            Console.WriteLine(security);

            TestPassword(security, test1);
            TestPassword(security, test2);
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
