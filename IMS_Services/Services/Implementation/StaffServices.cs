using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System.Data;


namespace IMS_Services.Services.Implementation;

public class StaffServices : ICRUDServices<Staff, short>
{

    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;


    public static short Add(Staff staff)
    {
        string query = @"
        INSERT INTO tbStaff VALUES 
        (@StaffName, @Gender, @BirthDate, @StaffPosition, @Address, @WorkNumber, @PersonalNumber, @HiredDate, @Salary, @StoppedWork);
        ";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@StaffName", staff.StaffName);
                cmd.Parameters.AddWithValue("@Gender", staff.Gender);
                cmd.Parameters.AddWithValue("@BirthDate", staff.BirthDate);
                cmd.Parameters.AddWithValue("@StaffPosition", staff.StaffPosition);
                cmd.Parameters.AddWithValue("@Address", staff.Address);
                cmd.Parameters.AddWithValue("@WorkNumber", staff.WorkNumber);
                cmd.Parameters.AddWithValue("@PersonalNumber", staff.PersonalNumber);
                cmd.Parameters.AddWithValue("@HiredDate", staff.HiredDate);
                cmd.Parameters.AddWithValue("@Salary", staff.Salary);
                cmd.Parameters.AddWithValue("@StoppedWork", staff.StoppedWork);
                try
                {
                    int effected = cmd.ExecuteNonQuery();
                    return (short)effected;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Failed in adding new Staff > {ex.Message}");

                }
            } 
        
        
    }

    public static bool Delete(short id)
    {
        string query = "DELETE FROM tbStaff WHERE StaffID = @id";
        
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

    public static IEnumerable<Staff> GetAll()
    {
        string query = "SELECT * FROM tbStaff;";
        
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
                        yield return record.ToStaff();
                    }
                }
                reader?.Close();
            
        }
    }

    public static Staff GetById(short id)
    {
        string query = "SELECT * FROM tbStaff WHERE StaffID = " + id;
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

            Staff? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToStaff();
                }
            }

            reader?.Close();
            return result;

        }
    }

    public static IEnumerable<Staff> GetByName(string name)
    {
        string query = "SELECT * FROM tbStaff WHERE StaffName LIKE '%" + name + "%'";
        
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
                        yield return record.ToStaff();
                    }
                }
                reader?.Close();
            
        }
    }

    public static bool Update(Staff staff)
    {
        string query = @"
        UPDATE tbStaff
        SET 
            StaffName = @name,
            Gender = @g,
            BirthDate = @bd,
            StaffPosition = @pos,
            Address = @add,
            WorkNumber = @wn,
            PersonalNumber = @pn,
            HiredDate = @hd,
            Salary = @sal,
            StoppedWork = @sw
        WHERE 
            StaffID = @id;";

        
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@name", staff.StaffName);
                cmd.Parameters.AddWithValue("@g", staff.Gender);
                cmd.Parameters.AddWithValue("@bd", staff.BirthDate);
                cmd.Parameters.AddWithValue("@pos", staff.StaffPosition);
                cmd.Parameters.AddWithValue("@add", staff.Address);
                cmd.Parameters.AddWithValue("@wn", staff.WorkNumber);
                cmd.Parameters.AddWithValue("@pn", staff.PersonalNumber);
                cmd.Parameters.AddWithValue("@hd", staff.HiredDate);
                cmd.Parameters.AddWithValue("@sal", staff.Salary);
                cmd.Parameters.AddWithValue("@sw", staff.StoppedWork);
                cmd.Parameters.AddWithValue("@id", staff.StaffId);

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
