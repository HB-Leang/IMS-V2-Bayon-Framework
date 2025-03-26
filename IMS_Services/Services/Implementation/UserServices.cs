using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System.Data;


namespace IMS_Services.Services.Implementation;

public class UserServices : ICRUDServices<User, short>
{
    private static DatabaseConnection connection = DatabaseConnection.Instance;

    public static short Add(User entity)
    {
        string query = @"
        INSERT INTO tbUser VALUES 
        (@un, @ps, @sid);";

        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            cmd.Parameters.AddWithValue("@un", entity.Username);
            cmd.Parameters.AddWithValue("@ps", entity.Password);
            cmd.Parameters.AddWithValue("@sid", entity.StaffID);

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
        string query = "DELETE FROM tbUser WHERE UserID = @id";

        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
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

    public static IEnumerable<User> GetAll()
    {
        string query = "SELECT * FROM tbUser;";

        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
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
                    yield return record.ToUser();
                }
            }
            reader?.Close();

        }
    }

    public static User GetById(short id)
    {
        string query = "SELECT * FROM tbUser WHERE UserID = " + id;
        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
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

            User? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToUser();
                }
            }

            reader?.Close();
            return result;

        }
    }

    public static IEnumerable<User> GetByName(string name)
    {
        string query = "SELECT * FROM tbUser WHERE UserName LIKE '%" + name + "%'";

        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
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
                    yield return record.ToUser();
                }
            }
            reader?.Close();

        }
    }

    public static bool Update(User entity)
    {
        string query = @"
        UPDATE tbUser
        SET 
            UserName = @un,
            Password = @pass,
            StaffID = @sid
        WHERE 
            UserID = @id;";


        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            cmd.Parameters.AddWithValue("@un", entity.Username);
            cmd.Parameters.AddWithValue("@pass", entity.Password);
            cmd.Parameters.AddWithValue("@sid", entity.StaffID);
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


    public static User GetUserByUserName(string userName)
    {
        string query = "SELECT * FROM tbUser WHERE Username = '" + userName + "'";

        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting user with Username, {userName} > {ex.Message}");
            }

            User? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToUser();
                }
            }
            reader?.Close();
            return result;
        }
    }







}
