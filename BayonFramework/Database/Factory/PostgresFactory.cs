using BayonFramework.Database.Factory.Driver;

namespace BayonFramework.Database.Factory;

public class PostgresFactory : DatabaseFactory
{
    public override IDatabase FactoryMethod()
    {
        return PostgresDatabase.Instance;
    }

    public override void ProvideConnectionString(string connectionString)
    {
        PostgresDatabase.addConnectionString(connectionString);
    }
}
