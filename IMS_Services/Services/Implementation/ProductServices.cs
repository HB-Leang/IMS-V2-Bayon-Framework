using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System.Data;

namespace IMS_Services.Services.Implementation;

public class ProductServices : ICRUDServices<Product, int>
{
    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;
    public static int Add(Product product)
    {
        string query = @"
        INSERT INTO tbProduct VALUES 
        (@name, @barcode, @salePrice, @uom, @ts, @cateID);";

        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@barcode", product.Barcode);
            cmd.Parameters.AddWithValue("@salePrice", product.SalePrice);
            cmd.Parameters.AddWithValue("@uom", product.UOM);
            cmd.Parameters.AddWithValue("@ts", product.TotalStock);
            cmd.Parameters.AddWithValue("@cateID", product.CategoryID);
;
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new product > {ex.Message}");

            }
        }
    }

    public static bool Delete(int id)
    {
        string query = "DELETE FROM tbProduct WHERE ProductID = @id;";

        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting product > {ex.Message}");
            }
        }
    }
    
    public static IEnumerable<Product> GetAll()
    {
        string query = "SELECT * FROM tbProduct";

        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all products > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToProduct();
                }
            }
            reader?.Close();

        }
    }

    public static Product GetById(int id)
    {
        string query = "SELECT * FROM tbProduct WHERE ProductID = " + id;
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting staff with ID, {id} > {ex.Message}");
            }

            Product? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToProduct();
                }
            }

            reader?.Close();
            return result;

        }
    }
    
    public static Product GetLowStockProducts()
    {
        string query = "SELECT * FROM tbProduct";
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting staff with ID, {id} > {ex.Message}");
            }

            Product? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToProduct();
                }
            }

            reader?.Close();
            return result;
        }

    public static IEnumerable<Product> GetByName(string name)
    {
        string query = "SELECT * FROM tbProduct WHERE ProductName LIKE '%" + name + "%'";

        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting Product with name, {name} > {ex.Message}");
            }
            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToProduct();
                }
            }
            reader?.Close();

        }
    }

    public static bool Update(Product product)
    {
        string query = @"
        UPDATE tbProduct
        SET 
            ProductName = @name,
            Barcode = @barcode,
            SalePrice = @salePrice,
            UOM = @uom,
            TotalStock = @ts,
            CategoryID = @cateID
        WHERE 
            ProductID = @id;";


        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@barcode", product.Barcode);
            cmd.Parameters.AddWithValue("@salePrice", product.SalePrice);
            cmd.Parameters.AddWithValue("@uom", product.UOM);
            cmd.Parameters.AddWithValue("@ts", product.TotalStock);
            cmd.Parameters.AddWithValue("@cateID", product.CategoryID);
            cmd.Parameters.AddWithValue("@id", product.ID);

            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating new Product > {ex.Message}");

            }


        }
    }

   
    
}
