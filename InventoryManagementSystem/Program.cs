using IMS_Services.Manager;
using IMS_Services.Utils;
using SSRMS_Project.Forms;


namespace InventoryManagementSystem;

public delegate void ProductEventHandler(object? sender);
public delegate void InventoryEventHandler(object? sender);
public delegate void ExportDetailHandler(object? sender);
public delegate void CountEventHandler(object? sender);
public delegate void CloseHandler();
public static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>


    public static DatabaseConnection connection = DatabaseConnection.Instance;

    [STAThread]
    static void Main()
    {
        //// Initialize Database
        ReadJsonFile.Load("appsettings.json");

        // Application Run
        ApplicationConfiguration.Initialize();
        //Application.Run(new LoginForm());
        Application.Run(new LoginForm());
    }
}