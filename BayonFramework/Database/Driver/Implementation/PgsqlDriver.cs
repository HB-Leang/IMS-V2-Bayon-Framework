using BayonFramework.Database.Helper.ConnectionString;
using Npgsql;

namespace BayonFramework.Database.Driver.Implementation;

public class PgsqlDriver : IDatabase
{
    private IConnectionStringProvider _connectionString;
    private static readonly PgsqlDriver? _instance = null;
    private NpgsqlConnection? _connection;

    private PgsqlDriver()
    {
        _connectionString = new PgsqlProvider();
        _connection = new NpgsqlConnection(_connectionString.Provide());
    }

    public static PgsqlDriver Instance
    {
        get
        {
            if (_instance == null)
            {
                return new PgsqlDriver();
            }
            return _instance;
        }
    }


    public void CloseConnection()
    {
        if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
        {
            Console.WriteLine("Closed");
            _connection.Close();
        }
    }

    public object? GetConnection()
    {
        Console.WriteLine("Connected");
        if (_connection!.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
        {
            try
            {
                _connection.Open();
                Console.WriteLine("Open");
            }
            catch (Exception ex)
            {
                throw new Exception($"Pgsql Drive => Connect Method: {ex.Message}");
            }
        }
        return _connection;
    }
}
