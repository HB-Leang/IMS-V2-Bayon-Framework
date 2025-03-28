using BayonFramework.Configure;
using BayonFramework.Database.Driver;


namespace BayonFramework;

public class Testing
{
    static void Main(string[] args)
    {
        try
        {

            App.Configure();

            Console.WriteLine(DatabaseEnviroment.DB_CONNECTION);
            Console.WriteLine(DatabaseEnviroment.DB_NAME);
            Console.WriteLine(DatabaseEnviroment.DB_HOST);
            Console.WriteLine(DatabaseEnviroment.DB_USERNAME);
            Console.WriteLine(DatabaseEnviroment.DB_PASSWORD);

            IDatabase db = Database.Database.Instance.GetDatabase();
            Console.WriteLine(db.GetHashCode());
            Console.WriteLine(db.GetHashCode());
            Console.WriteLine(db.GetHashCode());





        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
