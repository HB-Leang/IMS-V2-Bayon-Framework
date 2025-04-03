using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using IMS_Services.Entities;
using System.Data;
using BayonFramework.Database.Driver;
using BayonFramework.Database;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;

namespace IMS_Services.Services.Implementation;

public class ExportServices : ICRUDServices<Export, int>
{

    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;

    public static int Add(Export entity)
    {
        SqlQuery query = new QueryBuilder(Export.TableName).Insert(
                new Dictionary<string, object>
                    {
                        {"ExportDate", entity.ExportDate },
                        {"TotalItems", entity.TotalItem },
                        {"TotalCost", entity.TotalCost },
                        {"HandledBy", entity.HandledBy },
                    }
                ).Build();
        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new export > {ex.Message}");

            }
        }
    }

    public static bool Delete(int id)
    {
        SqlQuery query = new QueryBuilder(Export.TableName).Delete().Where("ExportID", ComparisonCondition.Equal, id).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting export > {ex.Message}");
            }
        }
    }

    public static IEnumerable<Export> GetAll()
    {
        SqlQuery query = new QueryBuilder(Export.TableName).Select().Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all Export > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToExport();
                }
            }
            reader?.Close();
        }
    }

    public static Export GetById(int id)
    {
        SqlQuery query = new QueryBuilder(Export.TableName)
                .Select()
                .Where("ExportID", ComparisonCondition.Equal, id)
                .Build();
        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting Export with ID, {id} > {ex.Message}");
            }

            Export? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToExport();
                }
            }
            reader?.Close();
            return result;
        }
    }

    public static IEnumerable<Export> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public static bool Update(Export entity)
    {
        SqlQuery query = new QueryBuilder(Export.TableName)
           .Update(new Dictionary<string, object>
               {
                    {"ExportDate", entity.ExportDate },
                    {"TotalItems", entity.TotalItem },
                    {"TotalCost", entity.TotalCost },
                    {"HandledBy", entity.HandledBy },
               }
           ).Where("ExportID", ComparisonCondition.Equal, entity.ID).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating Export > {ex.Message}");

            }
        }
    }
}
