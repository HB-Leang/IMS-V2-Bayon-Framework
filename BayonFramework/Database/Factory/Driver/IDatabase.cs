namespace BayonFramework.Database.Factory.Driver;

public interface IDatabase
{
    public object GetConnection();
    public void CloseConnection();
}