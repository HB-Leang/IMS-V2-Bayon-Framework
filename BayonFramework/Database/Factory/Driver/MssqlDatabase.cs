using Microsoft.Data.SqlClient;

namespace BayonFramework.Database.Factory.Driver;

public class MssqlDatabase : IDatabase
{
    private static readonly MssqlDatabase? _instance = null;
    private static string _connectionString = "";
    private SqlConnection _connection;

    private MssqlDatabase()
    {
        Console.WriteLine(_connectionString);
        _connection = new SqlConnection(_connectionString);
    }
    public static MssqlDatabase Instance
    {
        get
        {
            if (_instance == null)
            {
                return new MssqlDatabase();
            }
            return _instance;
        }
    }
    public static void addConnectionString(string connectionString)
    {
        _connectionString = connectionString;
    }
    public object GetConnection()
    {
        Console.WriteLine("Connected");
        if (_connection!.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
        {
            try
            {
                Console.WriteLine("Opened");
                _connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        return _connection;
    }
    public void CloseConnection()
    {
        if (_connection!.State == System.Data.ConnectionState.Open)
        {
            Console.WriteLine("Closed");
            _connection.Close();
        }
    }
}
