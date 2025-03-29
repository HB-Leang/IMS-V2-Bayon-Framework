using BayonFramework.Configure;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;
using BayonFramework.Database.Driver;
using Microsoft.Data.SqlClient;


namespace BayonFramework;

public class Testing
{
    static void Main(string[] args)
    {
        try
        {
            //App.Configure();
            //IDatabase db = Database.Database.Instance.GetDatabase();
            //SqlConnection connection = (SqlConnection)db.GetConnection()!;

            //var result1 = new QueryBuilder("tbUser")
            //    .Where("UserName", ComparisonCondition.Like, "%name%")
            //    .Build();

            //Console.WriteLine(result1.Query);
            //foreach (var param in result1.Parameters)
            //{
            //    Console.WriteLine(param.Key);
            //    Console.WriteLine(param.Value);
            //}

            var builder1 = new QueryBuilder("Products")
                .Insert(new Dictionary<string, object>
                    {
                        { "ProductName", "Phone" },
                        { "Price", 599.99 }
                    });
            SqlQuery insertQuery = builder1.Build();


            Console.WriteLine(insertQuery.Query);
            foreach (var param in insertQuery.Parameters)
            {
                Console.WriteLine(param.Key);
                Console.WriteLine(param.Value);
            }

            //var builder2 = new QueryBuilder("Orders").Insert(new Dictionary<string, object>{ 
            //            { "OrderDate", DateTime.Now },
            //            { "Total", 149.99 },
            //            { "Status", "Pending" }
            //        }).Build();


            //Console.WriteLine(builder2.Query);
            //foreach (var param in builder2.Parameters)
            //{
            //    Console.WriteLine(param.Key);
            //    Console.WriteLine(param.Value);
            //}

            //using (SqlCommand cmd = new SqlCommand(result1.Query, connection))
            //{ 
            //    SqlDataReader? reader = null;
            //    try
            //    {
            //        reader = result1.GetSqlCommand(cmd).ExecuteReader();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new Exception($"Error in getting staff with ID > {ex.Message}");
            //    }

            //    if (reader != null && reader.HasRows == true)
            //    {
            //        if (reader.Read() == true)
            //        {
            //            Console.WriteLine(reader);
            //        }
            //    }
            //    reader?.Close();
            //}


            //var result2 = new QueryBuilder("tbUser")
            //    .Join("INNER", "Orders", "Users.Id = Orders.UserId")
            //    .Where("Age", ComparisonCondition.Equal, 10)
            //    .Where("Name", ComparisonCondition.Like, "%kakada%", LogicalCondition.And)
            //    .Where(
            //        query => query.Where("Age", ComparisonCondition.GreaterThan, 10).Where("Sex", ComparisonCondition.Between, 0, LogicalCondition.And, 1)
            //        , LogicalCondition.Or
            //    )
            //    .OrderBy("Name")
            //    .Limit(10)
            //    .Build();

            //Console.WriteLine(result2.Query);
            //foreach (var param in result2.Parameters)
            //    Console.WriteLine(param);

            //var result3 = new QueryBuilder("tbUser").Build();
            //Console.WriteLine(result3.Query);
            //foreach (var param in result3.Parameters)
            //    Console.WriteLine(param);

            //var result4 = new QueryBuilder("tbUser")
            //    .Where("Age", ComparisonCondition.Equal, 10)
            //    .Build();
            //Console.WriteLine(result4.Query);
            //foreach (var param in result4.Parameters)
            //    Console.WriteLine(param);


            //Console.WriteLine(result1.GetHashCode());
            //Console.WriteLine(result2.GetHashCode());
            //Console.WriteLine(result3.GetHashCode());
            //Console.WriteLine(result4.GetHashCode());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
