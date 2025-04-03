using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System.Data;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;

namespace IMS_Services.Services.Implementation;

public class CategoryServices : ICRUDServices<Category, byte>
{
    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;

    public static byte Add(Category entity)
    {
        SqlQuery query = new QueryBuilder("tbCategory").Insert(
                new Dictionary<string, object>
                    {
                        {"CategoryName", entity.Name! },
                        {"CategoryDesc", entity.Description! },
                    }
                ).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
           

            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return (byte)effected;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new Category > {ex.Message}");

            }
        }
    }

    public static bool Delete(byte id)
    {
        SqlQuery query = new QueryBuilder(Category.TableName).Delete().Where("CategoryID", ComparisonCondition.Equal, id).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting Category > {ex.Message}");

            }
        }
    }

    public static IEnumerable<Category> GetAll()
    {
        SqlQuery query = new QueryBuilder(Category.TableName).Select().Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = query.GetSqlCommand(cmd).ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all Categorys > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToCategory();
                }
            }
            reader?.Close();

        }
    }

    public static Category GetById(byte id)
    {
        SqlQuery query = new QueryBuilder(Category.TableName)
                .Select()
                .Where("CategoryID", ComparisonCondition.Equal, id)
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
                throw new Exception($"Error in getting Category with ID, {id} > {ex.Message}");
            }

            Category? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToCategory();
                }
            }

            reader?.Close();
            return result;

        }
    }

    public static IEnumerable<Category> GetByName(string name)
    {
        SqlQuery query = new QueryBuilder(User.TableName)
                .Select()
                .Where("CategoryName", ComparisonCondition.Like, $"%{name}%")
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
                throw new Exception($"Error in getting Category with name, {name} > {ex.Message}");
            }
            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToCategory();
                }
            }
            reader?.Close();

        }
    }

    public static bool Update(Category entity)
    {

        SqlQuery query = new QueryBuilder(Category.TableName)
            .Update(new Dictionary<string, object>
                {
                    {"CategoryName", entity.Name! },
                    {"CategoryDesc", entity.Description }
                }
            ).Where("CategoryID", ComparisonCondition.Equal, entity.ID).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            

            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating Category > {ex.Message}");

            }
        }
    }
}
