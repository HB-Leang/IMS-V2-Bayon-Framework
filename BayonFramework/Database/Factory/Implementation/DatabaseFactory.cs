using BayonFramework.Database.Driver;
using BayonFramework.Database.Driver.Implementation;
using BayonFramework.Database.Factory;

namespace BayonFramework.Database.Factory.Implementation;

public class DatabaseFactory : AbstractDatabaseFactory
{
    public IDatabase CreateMssql()
    {
        return MssqlDriver.Instance;
    }

    public IDatabase CreatePgsql()
    {
        return PgsqlDriver.Instance;
    }
}