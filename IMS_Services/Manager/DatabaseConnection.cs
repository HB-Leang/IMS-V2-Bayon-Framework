using Microsoft.Data.SqlClient;
using IMS_Services.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Manager;

public class DatabaseConnection
{
    private static DatabaseConnection? _instance = null;

    private static readonly object _lock = new object();

    private SqlConnection? _connection;

    private readonly string? _connectionString = null;


    private DatabaseConnection()
    {
        _connectionString = ReadJsonFile.Read;
        _connection = new SqlConnection(_connectionString);
    }

    public static DatabaseConnection Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                }
            }
            return _instance;
        }
    }

    public SqlConnection GetConnection()
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
