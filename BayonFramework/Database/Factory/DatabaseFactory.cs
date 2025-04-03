using BayonFramework.Configuration;
using BayonFramework.Database.Driver;
using BayonFramework.Database.Driver.Implementation;

namespace BayonFramework.Database.Factory;

public class DatabaseFactory
{
    public IDatabase CreateDatabase()
    {
        string? dbConnection = DatabaseEnviroment.DB_CONNECTION ?? throw new Exception("Database can't instanciation.DB_Connection must be not null");
        if (dbConnection.Equals("mssql"))
        {
            return MssqlDriver.Instance;
        }
        return PgsqlDriver.Instance;
    }
}