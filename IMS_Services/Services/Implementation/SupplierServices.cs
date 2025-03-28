using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System.Data;

namespace IMS_Services.Services.Implementation;

public class SupplierServices : ICRUDServices<Supplier, byte>
{
    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;

    public static byte Add(Supplier entity)
    {
        string query = @"
        INSERT INTO tbSupplier VALUES 
        (@n, @e, @ph, @add, @pm, @pt);
        ";

        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@n", entity.Name);
            cmd.Parameters.AddWithValue("@e", entity.Email);
            cmd.Parameters.AddWithValue("@ph", entity.Phone);
            cmd.Parameters.AddWithValue("@add", entity.Address);
            cmd.Parameters.AddWithValue("@pm", entity.PaymentMethod);
            cmd.Parameters.AddWithValue("@pt", entity.PaymentTerm);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return (byte)effected;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new Staff > {ex.Message}");

            }
        }
    }

    public static bool Delete(byte id)
    {
        string query = "DELETE FROM tbSupplier WHERE SupplierID = @id;";

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
                throw new Exception($"Failed in deleting new Staff > {ex.Message}");

            }
        }
    }

    public static IEnumerable<Supplier> GetAll()
    {
        string query = "SELECT * FROM tbSupplier;";

        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all staffs > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToSupplier();
                }
            }
            reader?.Close();

        }
    }

    public static Supplier GetById(byte id)
    {
        string query = "SELECT * FROM tbSupplier WHERE SupplierID = " + id;
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

            Supplier? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToSupplier();
                }
            }

            reader?.Close();
            return result;

        }
    }

    public static IEnumerable<Supplier> GetByName(string name)
    {
        string query = "SELECT * FROM tbSupplier WHERE SupplierName LIKE '%" + name + "%'";

        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting staff with name, {name} > {ex.Message}");
            }
            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToSupplier();
                }
            }
            reader?.Close();

        }
    }

    public static bool Update(Supplier entity)
    {
        string query = @"
        UPDATE tbSupplier
        SET 
            SupplierName = @n,
            Email = @e,
            Address = @add,
            Phone = @ph,
            PaymentMethod = @pm,
            PaymentTerm = @pt
        WHERE 
            SupplierID = @id;";


        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@n", entity.Name);
            cmd.Parameters.AddWithValue("@e", entity.Email);
            cmd.Parameters.AddWithValue("@add", entity.Address);
            cmd.Parameters.AddWithValue("@ph", entity.Phone);
            cmd.Parameters.AddWithValue("@pm", entity.PaymentMethod);
            cmd.Parameters.AddWithValue("@pt", entity.PaymentTerm);

            cmd.Parameters.AddWithValue("@id", entity.ID);

            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating new Staff > {ex.Message}");

            }
        }
    }
}
