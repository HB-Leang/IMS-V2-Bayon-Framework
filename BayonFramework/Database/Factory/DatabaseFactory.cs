using BayonFramework.Database.Factory.Driver;

namespace BayonFramework.Database.Factory;
public abstract class DatabaseFactory
{
    public abstract IDatabase FactoryMethod();
    public abstract void ProvideConnectionString(string connectionString);
}
