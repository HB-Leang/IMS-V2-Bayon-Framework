using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Database_Tools
{
    public partial class Databasetools : Form
    {
        public static IConfiguration? Configuration { get; set; } = null;

        string? ConnectionStringToDatabase;

        string fileName = "appsettings.json";

        bool IsConnected = false;


        // Define the relative path from the current directory to the appsettings.json file
        string relativePathToAppSettings = @"appsettings.json";

        // Get the current directory where the executable is running
        string currentDirectory = Directory.GetCurrentDirectory();

        // Combine the current directory with the relative path
        string fullPathToAppSettings;

        public Databasetools()
        {
            InitializeComponent();
            cbAthor.SelectedIndex = -1;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            cbAthor.SelectedValueChanged += Select_Handling_Authentication;
            LoadConfiguration("DBConnectionFormat.json");

            btnConnect.Click += DoClickConnect;
            btnClose.Click += DoClickSave;
            
            fullPathToAppSettings = Path.GetFullPath(Path.Combine(currentDirectory, relativePathToAppSettings));

        }
        private void DoClickConnect(object? sender, EventArgs e)
        {
            if (txtServerName.Text == "") { MessageBox.Show("Server name is required!!!"); return; }
            if (txtDatabaseName.Text == "") { MessageBox.Show("Database name is required!!!"); return; }
            if (cbAthor.SelectedItem == null) { MessageBox.Show("Authentication is required!!!"); return; }


            if (cbAthor.SelectedItem.ToString().Equals("SQL Server Authentication"))
            {

                if (txtUserName.Text == "") { MessageBox.Show("User is required!!!"); return; }
                if (txtPassword.Text == "") { MessageBox.Show("Password is required!!!"); return; }
                ConnectionStringToDatabase = string.Format(ConnectionStringToDatabase, txtServerName.Text, txtDatabaseName.Text, txtUserName.Text, txtPassword.Text);

            }
            else
            {
                ConnectionStringToDatabase = string.Format(ConnectionStringToDatabase, txtServerName.Text, txtDatabaseName.Text);
            }

            try
            {
                var conn = new SqlConnection(ConnectionStringToDatabase);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                IsConnected = true;
                MessageBox.Show("Connected to database successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                IsConnected = false;
                MessageBox.Show("Failed to connect to the server", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception($"Failed to connect to the server > {ex.Message}");
            }

        }

        private void DoClickSave(object? sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("Please test conection first!", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnection dBConnection = new DBConnection();
            using (StreamReader reader = new StreamReader(fullPathToAppSettings))
            {
                string json = reader.ReadToEnd();
                dBConnection = System.Text.Json.JsonSerializer.Deserialize<DBConnection>(json);
            }

            dBConnection.ConnectionString = ConnectionStringToDatabase;
            string dbJsonData = JsonConvert.SerializeObject(dBConnection);

            using (StreamWriter writer = new StreamWriter(fullPathToAppSettings))
            {
                string json = System.Text.Json.JsonSerializer.Serialize(dBConnection, new JsonSerializerOptions { WriteIndented = true });
                writer.Write(json);
            }
            MessageBox.Show("Database Configuration save successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void DBConnection_Handler(object? sender, FormClosedEventArgs e)
        {
            File.Delete(fullPathToAppSettings);
        }
        private void Select_Handling_Authentication(object? sender, EventArgs e)
        {
            if (cbAthor.SelectedItem != null)
            {
                string? authentication = cbAthor.SelectedItem.ToString();
                if (authentication == null) return;
                if (authentication.Equals("SQL Server Authentication"))
                {
                    txtUserName.Enabled = true;
                    txtPassword.Enabled = true;
                    ConnectionStringToDatabase = GetDBConnectionSetting("DBConnectionStringServerAuth");
                }
                else
                {
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    txtUserName.Clear();
                    txtPassword.Clear();
                    ConnectionStringToDatabase = GetDBConnectionSetting("DBConnectionStringWindowAuth");
                }
            }
        }

        public static void LoadConfiguration(string jsonFile)
        {
            var builder = new ConfigurationBuilder()
              .AddJsonFile(jsonFile, optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }

        private static string GetDBConnectionSetting(string connectionType)
        {
            var procSettingSection = Configuration.GetRequiredSection($"{connectionType}");
            string? procSetting = procSettingSection.Value;
            return procSetting;
        }
        class DBConnection
        {
            public string? ConnectionString { get; set; }
        }
    }
}