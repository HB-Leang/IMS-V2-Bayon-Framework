using BayonFramework.Configuration;
using BayonFramework.Validation;

namespace BayonFramework.Database.Helper.ConnectionString;

public class PgsqlProvider : IConnectionStringProvider
{
    public string Provide()
    {
        Validator.isNullOrEmpty("Postgres Username", DatabaseEnviroment.DB_USERNAME);
        Validator.isNullOrEmpty("Postgres Password", DatabaseEnviroment.DB_PASSWORD);

        return $"Host={DatabaseEnviroment.DB_HOST}; " +
            $"Username={DatabaseEnviroment.DB_USERNAME}; " +
            $"Password={DatabaseEnviroment.DB_PASSWORD}; " +
            $"Database={DatabaseEnviroment.DB_NAME}";
    }
}
