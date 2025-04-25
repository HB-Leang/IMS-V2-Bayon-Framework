using BayonFramework.Configuration;
using BayonFramework.Database.Driver;
using BayonFramework.Database.Factory;
using BayonFramework.Database.Factory.Implementation;

namespace BayonFramework.Database;

public class Database
{
    private static readonly Database? _instance = null;
    private AbstractDatabaseFactory _factory;
    private Database()
    {
        _factory = new DatabaseFactory();
    } 
    public static Database Instance
    {
        get
        {
            if( _instance == null)
            {
                return new Database();
            }
            return _instance;
        }
    }

    public IDatabase GetDatabase()
    {
        string? dbConnection = DatabaseEnviroment.DB_CONNECTION ?? throw new Exception("Database can't instanciation.DB_Connection must be not null");
        if (dbConnection.Equals("mssql"))
        {
            return _factory.CreateMssql();
        }
        return _factory.CreatePgsql();
    }
}
