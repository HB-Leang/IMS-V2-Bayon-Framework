
using BayonFramework.Database.Factory.Driver;

namespace BayonFramework.Database.Factory;

public class MssqlFectory : DatabaseFactory
{
    public override IDatabase FactoryMethod()
    {
        return MssqlDatabase.Instance;
    }

    public override void ProvideConnectionString(string connectionString)
    {
        MssqlDatabase.addConnectionString(connectionString);
    }
}
