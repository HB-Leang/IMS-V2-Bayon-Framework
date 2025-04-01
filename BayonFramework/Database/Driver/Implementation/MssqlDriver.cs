using BayonFramework.Database.Helper.ConnectionString;
using Microsoft.Data.SqlClient;

namespace BayonFramework.Database.Driver.Implementation;

public class MssqlDriver : IDatabase
{
    private IConnectionStringProvider _connectionString;
    private static readonly MssqlDriver? _instance = null;
    private readonly SqlConnection? _connection;

    private MssqlDriver()
    {
        _connectionString = new MssqlProvider();
        _connection = new SqlConnection(_connectionString.Provide());
    }
    public static MssqlDriver Instance
    {
        get
        {
            if(_instance == null)
            {
                return new MssqlDriver();
            }
            return _instance;
        }
    }
    public void CloseConnection()
    {
        if (_connection!.State == System.Data.ConnectionState.Open)
        {
            Console.WriteLine("Closed");
            _connection.Close();
        }
    }
    public object? GetConnection()
    {
        Console.WriteLine("Connected");
        if (_connection!.State == System.Data.ConnectionState.Closed ||
            _connection.State == System.Data.ConnectionState.Broken)
        {
            try
            {
                _connection.Open();
                Console.WriteLine("Opened");
            }
            catch (Exception ex)
            {
                throw new Exception($"Mssql Drive => Connect Method: {ex.Message}");

            }
        }
        return _connection;
    }
}