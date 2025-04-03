
namespace DatabaseToolVersion2
{
    public partial class DatabaseTool : Form
    {
        //private string destinationPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\BayonFramework\.env");
        private string sourcePath = Path.Combine(Directory.GetCurrentDirectory(), ".env");


        private Dictionary<string, string> _envVariable = new Dictionary<string, string>();

        public DatabaseTool()
        {
            InitializeComponent();
            cboConnection.DataSource = new List<string>()
            {
                "mssql", "pgsql"
            };

            cboConnection.SelectedIndex = 0;

            btnSave.Click += DoClickSave;

            if (File.Exists(sourcePath))
            { 
                foreach (string line in File.ReadAllLines(sourcePath))
                {
                    if (!string.IsNullOrWhiteSpace(line) && line.Contains("="))
                    {
                        var parts = line.Split('=', 2);
                        _envVariable[parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }
        }

        private void DoClickSave(object? sender, EventArgs e)
        {
            try
            {
                if (cboConnection.SelectedIndex == -1) { MessageBox.Show("Connection is required!!!"); return; }
                if (txtHost.Text == "") { MessageBox.Show("Host is required!!!"); return; }
                if (txtDbName.Text == "") { MessageBox.Show("Host is required!!!"); return; }

                _envVariable["DB_CONNECTION"] = cboConnection.SelectedValue!.ToString() ?? _envVariable["DB_CONNECTION"];
                _envVariable["DB_HOST"] = txtHost.Text;
                _envVariable["DB_DATABASE"] = txtDbName.Text;
                _envVariable["DB_USERNAME"] = txtUserName.Text ?? "";
                _envVariable["DB_PASSWORD"] = txtPassword.Text ?? "";

                var updatedLines = new List<string>();
                foreach (var kvp in _envVariable)
                {
                    updatedLines.Add($"{kvp.Key}={kvp.Value}");
                }
                File.WriteAllLines(sourcePath, updatedLines);

                //File.Copy(sourcePath, destinationPath, overwrite: true);

                //_envVariable["DB_HOST"] = "";
                //_envVariable["DB_DATABASE"] = "";
                //_envVariable["DB_USERNAME"] = "";
                //_envVariable["DB_PASSWORD"] = "";

                //updatedLines.Clear();
                //foreach (var kvp in _envVariable)
                //{
                //    updatedLines.Add($"{kvp.Key}={kvp.Value}");
                //}
                //File.WriteAllLines(sourcePath, updatedLines);

                MessageBox.Show("Success!!!");
                this.Dispose();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
