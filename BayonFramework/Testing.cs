using BayonFramework.Configure;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;
using BayonFramework.Database.Driver;
using BayonFramework.Security;
using BayonFramework.Security.Builder;
using BayonFramework.Security.Encrypt.Enum;
using BayonFramework.Security.PasswordFilter.Rule;
using BayonFramework.Security.Request;
using Microsoft.Data.SqlClient;

namespace BayonFramework;

public class Testing
{
    static void Main(string[] args)
    {
        try
        {

            //QueryTesting.Run();
             AuthTesting.Run();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }




}
