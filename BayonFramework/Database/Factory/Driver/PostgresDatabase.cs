using Npgsql;

namespace BayonFramework.Database.Factory.Driver;

public class PostgresDatabase : IDatabase
{
    private static readonly PostgresDatabase? _instance = null;
    private static string _connectionString = "";
    private readonly NpgsqlConnection? _connection;
    private PostgresDatabase()
    {
        Console.WriteLine(_connectionString);
        _connection = new NpgsqlConnection(_connectionString);
    }
    public static PostgresDatabase Instance
    {
        get
        {
            if (_instance == null)
            {
                return new PostgresDatabase();
            }
            return _instance;
        }
    }
    public static void addConnectionString(string connectionString)
    {
        _connectionString = connectionString;
    }
    public void CloseConnection()
    {
        if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
        {
            Console.WriteLine("Closed");
            _connection.Close();
        }
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
}
