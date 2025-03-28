using BayonFramework.Database.Driver;

namespace BayonFramework.Database.Factory;

public interface AbstractDatabaseFactory
{
    IDatabase CreateMssql();
    IDatabase CreatePgsql();
}
