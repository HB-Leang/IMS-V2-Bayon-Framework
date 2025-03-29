using BayonFramework.Database;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;
using BayonFramework.Database.Driver;
using IMS_Services.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace IMS_Services.Services.Implementation;

public class UserServices : ICRUDServices<User, short>
{
    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;
    public static short Add(User entity)
    {
        //string query = @"INSERT INTO tbUser VALUES (@un, @ps, @sid);";

        SqlQuery query = new QueryBuilder("tbUser").Insert(new Dictionary<string, object>
            {
                {"Username", entity.Username! },
                {"Password", entity.Password! },
                {"StaffID", entity.StaffID},
            }).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            //cmd.Parameters.AddWithValue("@un", entity.Username);
            //cmd.Parameters.AddWithValue("@ps", entity.Password);
            //cmd.Parameters.AddWithValue("@sid", entity.StaffID);
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
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

    public static IEnumerable<User> GetAll()
    {
        //string query = "SELECT * FROM tbUser;";

        SqlQuery query = new QueryBuilder("tbUser").Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
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
        //string query = "SELECT * FROM tbUser WHERE UserID = " + id;

        SqlQuery query = new QueryBuilder("tbUser")
                .Where("UserID", ComparisonCondition.Equal, id)
                .Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = query.GetSqlCommand(cmd).ExecuteReader();
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
            return result!;
        }
    }

    public static IEnumerable<User> GetByName(string name)
    {
        //string query = "SELECT * FROM tbUser WHERE UserName LIKE '%" + name + "%'";

        SqlQuery query = new QueryBuilder("tbUser")
                .Where("UserName", ComparisonCondition.Like, $"%{name}%")
                .Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = query.GetSqlCommand(cmd).ExecuteReader();
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

        using (SqlCommand cmd = new SqlCommand(query, connection))
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
        //string query = "SELECT * FROM tbUser WHERE Username = '" + userName + "'";

        SqlQuery query = new QueryBuilder("tbUser")
                .Where("Username", ComparisonCondition.Equal, userName)
                .Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = query.GetSqlCommand(cmd).ExecuteReader();
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
            return result!;
        }
    }

}
