using BayonFramework.Database.Builder;
using BayonFramework.Database.Manager;

namespace BayonFramework;

public class Testing
{
    static void Main(string[] args)
    {
        DatabaseManager dbManager = DatabaseManager.Instance;
        var database = dbManager.Database();

        //ISqlBuilder queryBuilder = new SqlQueryBuilder().Select().From("tbuser").Where("id = 10");
        //Console.WriteLine(queryBuilder.Build());

    }
}
