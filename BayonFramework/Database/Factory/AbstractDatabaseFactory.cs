using BayonFramework.Database.Driver;

namespace BayonFramework.Database.Factory;

public abstract class AbstractDatabaseFactory
{
    public abstract IDatabase CreateMssql();
    public abstract IDatabase CreatePgsql();
}
