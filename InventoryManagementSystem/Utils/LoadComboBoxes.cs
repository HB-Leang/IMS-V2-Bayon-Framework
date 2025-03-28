

using IMS_Services.Manager;
using IMS_Services.Entities;
using Microsoft.Data.SqlClient;
using System.Data;
using BayonFramework.Database.Driver;
using BayonFramework.Database;

namespace InventoryManagementSystem.Utils;

public class LoadComboBoxes
{
    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;
    public static void LoadCategoryCBO(ComboBox comboBox)
    {
        string query = "SELECT CategoryID, CategoryName FROM tbCategory";
        List<Category> list = new List<Category>();
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        //comboBox.Items.Add(new Category()
                        //{ 
                        //    ID = reader.GetByte("CategoryID"),
                        //    Name = reader.GetString("CategoryName"),
                        //});
                        list.Add(new Category()
                        {
                            ID = reader.GetByte("CategoryID"),
                            Name = reader.GetString("CategoryName"),
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        comboBox.DataSource = list;
        comboBox.ValueMember = "ID";
        comboBox.DisplayMember = "Name";
        comboBox.SelectedIndex = -1;
    }

    public static void LoadHandleByCBO(ComboBox comboBox)
    {
        string query = "SELECT StaffID, StaffName FROM tbStaff";
        List<Staff> list = new List<Staff>();
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        list.Add(new Staff()
                        {
                            StaffId = reader.GetInt16("StaffID"),
                            StaffName = reader.GetString("StaffName"),
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        comboBox.DataSource = list;
        comboBox.ValueMember = "StaffId";
        comboBox.DisplayMember = "StaffName";
        comboBox.SelectedIndex = -1;
    }


    public static void LoadSupplierCBO(ComboBox comboBox)
    {
        string query = "SELECT SupplierID, SupplierName FROM tbSupplier";
        List<Supplier> list = new List<Supplier>();
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        list.Add(new Supplier()
                        {
                            ID = reader.GetByte("SupplierID"),
                            Name = reader.GetString("SupplierName"),
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        comboBox.DataSource = list;
        comboBox.ValueMember = "ID";
        comboBox.DisplayMember = "Name";
        comboBox.SelectedIndex = -1;
    }


    public static void LoadProductCBO(ComboBox comboBox)
    {
        string query = "SELECT ProductID, ProductName, SalePrice FROM tbProduct";
        List<Product> list = new List<Product>();
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            ID = reader.GetInt32("ProductID"),
                            Name = reader.GetString("ProductName"),
                            SalePrice = reader.GetDecimal("SalePrice"),
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        comboBox.DataSource = list;
        comboBox.ValueMember = "ID";
        comboBox.DisplayMember = "Name";
        comboBox.SelectedIndex = -1;
    }
    public static void LoadImportID(ComboBox comboBox)
    {
        string query = "SELECT ImportID FROM tbImport ORDER BY ImportID DESC";
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader.GetInt32("ImportID"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        comboBox.SelectedIndex = -1;
    }

    public static void LoadExportID(ComboBox comboBox)
    {
        string query = "SELECT ExportID FROM tbExport ORDER BY ExportID DESC";
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader.GetInt32("ExportID"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        comboBox.SelectedIndex = -1;
    }

    public static void LoadInventoryID(ComboBox comboBox, int proID)
    {

        string query = @"SELECT InvID, CurrentStock FROM tbInventory 
                    WHERE ProductID = @proID AND CurrentStock > 0 AND ExpirationDate > GETDATE()
                    ORDER BY CurrentStock DESC";
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@proID", proID);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    if(reader.HasRows)
                        while (reader.Read())
                        {
                            string item = reader.GetInt32("InvID").ToString() + " - " +
                            reader.GetInt16("CurrentStock").ToString();
                            comboBox.Items.Add(item);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        comboBox.SelectedIndex = -1;
    }

}
