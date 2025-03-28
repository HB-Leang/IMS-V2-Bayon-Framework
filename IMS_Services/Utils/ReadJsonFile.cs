using BayonFramework.Configure;
using Microsoft.Extensions.Configuration;
namespace IMS_Services.Utils;

public class ReadJsonFile
{
    private static IConfiguration? Configuration { get; set; } = null;
    private static string ConnectionStringKey { get; set; } = "ConnectionString";
    private static string? _connectionString = null;

    public static void Load(string jsonFile)
    {
        try
        {
            App.Configure();


            var builder = new ConfigurationBuilder()
                 .AddJsonFile(jsonFile, optional: false, reloadOnChange: true);
            Configuration = builder.Build();

            _connectionString = Configuration.GetRequiredSection(ConnectionStringKey).Value;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }

    public static string Read
    {
        get
        {
            return _connectionString!;
        }
    }

}
