using BayonFramework.Database.Driver;
using BayonFramework.Database.Factory;

namespace BayonFramework.Database;

public class Database
{
    private static readonly Database? _instance = null;
    private IDatabase _database;

    private Database()
    {
        _database = new DatabaseFactory().CreateDatabase();
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
        return _database;
    }
}
