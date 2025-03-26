using BayonFramework.Database.Factory;
using BayonFramework.Database.Factory.Driver;
using BayonFramework.Validation;
namespace BayonFramework.Database.Manager;

public class DatabaseManager
{
    private static readonly DatabaseManager? _instance = null; 
    private DatabaseManager()
    {
    }
    private string DatabaseConnectionString(Dictionary<string, string> config)
    {
        switch (config["DB_CONNECTION"])
        {
            case "pgsql":
                Validator.isNullOrEmpty(config["DB_USERNAME"]);
                Validator.isNullOrEmpty(config["DB_PASSWORD"]);

                return $"Host={config["DB_HOST"]}; Username={config["DB_USERNAME"]}; Password={config["DB_PASSWORD"]}; Database={config["DB_DATABASE"]}";
            case "mssql":
                return $"data source={config["DB_HOST"]}; initial catalog={config["DB_DATABASE"]}; trusted_connection=true; encrypt=false";
            default:
                throw new NotSupportedException("Unsupported DB_CONNECTION type.");
        }
    }
    private Dictionary<string, string> ConfigEnviroment()
    {
        DotNetEnv.Env.Load();
        var connection = Environment.GetEnvironmentVariable("DB_CONNECTION")!;
        var host = Environment.GetEnvironmentVariable("DB_HOST")!;
        var databaseName = Environment.GetEnvironmentVariable("DB_DATABASE")!;
        var username = Environment.GetEnvironmentVariable("DB_USERNAME")!;
        var password = Environment.GetEnvironmentVariable("DB_PASSWORD")!;

        Validator.isNullOrEmpty(connection);
        Validator.isNullOrEmpty(host);
        Validator.isNullOrEmpty(databaseName);

        return new Dictionary<string, string>
        {
            { "DB_CONNECTION", connection },
            { "DB_HOST", host },
            { "DB_DATABASE", databaseName },
            { "DB_USERNAME", username },
            { "DB_PASSWORD", password }
        };
    }
    private DatabaseFactory GetFectory(string databaseConnection, string connectionString)
    {
        DatabaseFactory? facotry = databaseConnection.ToLower() switch
        {
            "pgsql" => new PostgresFactory(),
            "mssql" => new MssqlFectory(),
            _ => throw new NotImplementedException()
        };
        facotry.ProvideConnectionString(connectionString);
        return facotry;
    }
    public static DatabaseManager Instance
    {
        get
        {
            if(_instance == null)
            {
                return new DatabaseManager();
            }
            return _instance;
        }
    }
    public IDatabase Database()
    {   
        var config = ConfigEnviroment();
        string connectionString = DatabaseConnectionString(config);
        return GetFectory(config["DB_CONNECTION"], connectionString).FactoryMethod();
    }
}
