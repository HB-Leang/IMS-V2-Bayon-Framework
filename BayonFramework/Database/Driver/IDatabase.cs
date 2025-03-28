namespace BayonFramework.Database.Driver;

public interface IDatabase
{
    object? GetConnection();
    void CloseConnection();
}