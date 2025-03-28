using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Services.Implementation;

public class ImportServices : ICRUDServices<Import, int>
{

    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;

    public static int Add(Import entity)
    {
        string query = @"
        INSERT INTO tbImport VALUES 
        (@d, @tc, @ti, @h, @s);";

        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@d", entity.ImportDate);
            cmd.Parameters.AddWithValue("@tc", entity.TotalCost);
            cmd.Parameters.AddWithValue("@ti", entity.TotalItem);
            cmd.Parameters.AddWithValue("@h", entity.HandledBy);
            cmd.Parameters.AddWithValue("@s", entity.SupplierID);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new Import > {ex.Message}");

            }
        }
    }

    public static bool Delete(int id)
    {
        string query = "DELETE FROM tbImport WHERE ImportID = @id;";

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

    public static IEnumerable<Import> GetAll()
    {
        string query = "SELECT * FROM tbImport;";

        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all Import > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToImport();
                }
            }
            reader?.Close();

        }
    }

    public static Import GetById(int id)
    {
        string query = "SELECT * FROM tbImport WHERE ImportID = " + id;
        using (SqlCommand cmd = new SqlCommand(query, connection))
        {

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting Import with ID, {id} > {ex.Message}");
            }

            Import? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToImport();
                }
            }

            reader?.Close();
            return result;

        }
    }

    public static IEnumerable<Import> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public static bool Update(Import entity)
    {
        string query = @"
        UPDATE tbImport
        SET 
            ImportDate = @d,
            TotalCost = @tc,
            TotalItem = @ti,
            HandledBy = @h,
            SupplierID = @s
        WHERE 
            ImportID = @id;";


        using (SqlCommand cmd = new SqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@d", entity.ImportDate);
            cmd.Parameters.AddWithValue("@tc", entity.TotalCost);
            cmd.Parameters.AddWithValue("@ti", entity.TotalItem);
            cmd.Parameters.AddWithValue("@h", entity.HandledBy);
            cmd.Parameters.AddWithValue("@s", entity.SupplierID);

            cmd.Parameters.AddWithValue("@id", entity.ID);

            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating new Import > {ex.Message}");

            }


        }
    }
}
