using BayonFramework.Configure;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

namespace BayonFramework.Database.Helper.ConnectionString;

public class MssqlProvider : IConnectionStringProvider
{
    public string Provide()
    {
        string? username = DatabaseEnviroment.DB_USERNAME;
        string? password = DatabaseEnviroment.DB_PASSWORD;
        if (CheckUserNameAndPassword(username, password))
        {
            return WindowsAuth();
        }
        return SqlServerAuth();
    }
    private string SqlServerAuth()
    {
        return $"data source={DatabaseEnviroment.DB_HOST}; initial catalog={DatabaseEnviroment.DB_NAME}; " +
            $"user id={DatabaseEnviroment.DB_USERNAME}; password={DatabaseEnviroment.DB_PASSWORD}; encrypt=false";
    }
    private string WindowsAuth()
    {
        return $"data source={DatabaseEnviroment.DB_HOST}; initial catalog={DatabaseEnviroment.DB_NAME}; trusted_connection=true; encrypt=false";
    }
    private bool CheckUserNameAndPassword(string? username, string? password)
    {
        return username.IsNullOrEmpty() && password.IsNullOrEmpty();
    }
}
