using BayonFramework.Database;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;
using BayonFramework.Database.Driver;
using BayonFramework.Security.Configure;
using BayonFramework.Security.Request;
using IMS_Services.Configure;
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
        Auth register = new AuthRequest(entity.Username!, entity.Password!).Build();

        var registerSecurity = new CustomRegisterSecurityConfigure(register);

        if (!registerSecurity.Execute())
        {
            throw new Exception(registerSecurity.ErrorMessage);
        }

        SqlQuery query = new QueryBuilder(User.TableName).Insert(new Dictionary<string, object>
        {
            {"Username", entity.Username! },
            {"Password", register.HashPassword },
            {"IsLocked", entity.IsLocked! },
            {"Attempt", entity.Attempt! },
            {"StaffID", entity.StaffID},
        }).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
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
        SqlQuery query = new QueryBuilder(User.TableName).Delete().Where("UserID", ComparisonCondition.Equal, id).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
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
        SqlQuery query = new QueryBuilder(User.TableName).Select().Build();

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
        SqlQuery query = new QueryBuilder(User.TableName)
                .Select()
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
        SqlQuery query = new QueryBuilder(User.TableName)
                .Select()
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

    public static bool Update(User entity, bool state)
    {
        SqlQuery query;
        Auth updateUser = new AuthRequest(entity.Username!, entity.Password!).Build();
        var security = new CustomRegisterSecurityConfigure(updateUser);

        if (!security.Execute())
        {
            throw new Exception(security.ErrorMessage);
        }

        if (state) {
            query = new QueryBuilder(User.TableName)
            .Update(new Dictionary<string, object>
                {
                {"Username", entity.Username! },
                {"Password", updateUser.HashPassword },
                {"IsLocked", entity.IsLocked! },
                {"Attempt", entity.Attempt! },
                {"StaffID", entity.StaffID},
                }
            ).Where("UserID", ComparisonCondition.Equal, entity.ID).Build();
        }
        else
        {
            query = new QueryBuilder(User.TableName)
            .Update(new Dictionary<string, object>
                {
                    {"Username", entity.Username! },
                    {"IsLocked", entity.IsLocked! },
                    {"Attempt", entity.Attempt! },
                    {"StaffID", entity.StaffID},
                }
            ).Where("UserID", ComparisonCondition.Equal, entity.ID).Build();
        }

        

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
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
        SqlQuery query = new QueryBuilder("tbUser")
                .Select()
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

    public static bool Update(User entity)
    {
        throw new NotImplementedException();
    }
}
