using BayonFramework.Validation;

namespace BayonFramework.Configuration;

public class DatabaseEnviroment
{
    public static readonly string? DB_CONNECTION = Environment.GetEnvironmentVariable("DB_CONNECTION");
    public static readonly string? DB_HOST = Environment.GetEnvironmentVariable("DB_HOST");
    public static readonly string? DB_NAME = Environment.GetEnvironmentVariable("DB_DATABASE");
    public static readonly string? DB_USERNAME = Environment.GetEnvironmentVariable("DB_USERNAME");
    public static readonly string? DB_PASSWORD = Environment.GetEnvironmentVariable("DB_PASSWORD");

    public static void LoaderConfiguration()
    {
        DotNetEnv.Env.Load();
        Validator.isNullOrEmpty("Env: Database Connection", DB_CONNECTION);
        Validator.isNullOrEmpty("Env: Database Host", DB_HOST);
        Validator.isNullOrEmpty("Env: Database Name ", DB_NAME);
    }
}
