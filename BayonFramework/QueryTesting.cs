using BayonFramework.Configuration;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;
using BayonFramework.Database.Driver;
using Microsoft.Data.SqlClient;

namespace BayonFramework
{
    public class QueryTesting
    {
        public static void Run()
        {
            App.Configure();
            IDatabase db = Database.Database.Instance.GetDatabase();
            SqlConnection connection = (SqlConnection)db.GetConnection()!;

            SqlQuery query1 = new QueryBuilder("tbUser").Select().Build();
            Console.WriteLine(query1.Query);
            foreach (var param in query1.Parameters)
                Console.WriteLine($"{param.Key}, {param.Value}");

            SqlQuery query2 = new QueryBuilder("tbUser")
                .Select()
                .Join("INNER", "tbRole", "Test")
                .Where("Age", ComparisonCondition.Equal, 10)
                .OrderBy("Name")
                .Limit(10)
                .Build();
            Console.WriteLine(query2.Query);
            foreach (var param in query2.Parameters)
                Console.WriteLine($"{param.Key}, {param.Value}");

            SqlQuery query3 = new QueryBuilder("tbUser").Insert(
                new Dictionary<string, object>
                    {
                        {"Username", "piko" },
                        {"Password", "piko1234" },
                        {"StaffID", 1},
                    }
                ).Build();
            Console.WriteLine(query3.Query);
            foreach (var param in query3.Parameters)
                Console.WriteLine($"{param.Key}, {param.Value}");

            SqlQuery query4 = new QueryBuilder("tbUser").Update(
                new Dictionary<string, object>
                    {
                        {"Username", "piko" },
                        {"Password", "piko1234" },
                        {"StaffID", 1},
                    }
                )
                .Where("UserID", ComparisonCondition.Equal, 10)
                .Build();
            Console.WriteLine(query4.Query);
            foreach (var param in query4.Parameters)
                Console.WriteLine($"{param.Key}, {param.Value}");

            SqlQuery query5 = new QueryBuilder("tbUser").Delete().Where("UserID", ComparisonCondition.Equal, 10).Build();
            Console.WriteLine(query5.Query);
            foreach (var param in query5.Parameters)
                Console.WriteLine($"{param.Key}, {param.Value}");
        }
    }
}
