using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using Microsoft.Data.SqlClient;
using System.Data;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;


namespace IMS_Services.Services.Implementation;

public class ImportServices : ICRUDServices<Import, int>
{

    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;

    public static int Add(Import entity)
    {
        SqlQuery query = new QueryBuilder(Import.TableName).Insert(
                new Dictionary<string, object>
                    {
                        {"ImportDate", entity.ImportDate },
                        {"TotalItem", entity.TotalItem },
                        {"TotalCost", entity.TotalCost },
                        {"HandledBy", entity.HandledBy },
                        {"SupplierID", entity.SupplierID },
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
                throw new Exception($"Failed in adding new Import > {ex.Message}");

            }
        }
    }

    public static bool Delete(int id)
    {
        SqlQuery query = new QueryBuilder(Import.TableName).Delete().Where("ImportID", ComparisonCondition.Equal, id).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting import > {ex.Message}");
            }
        }
    }

    public static IEnumerable<Import> GetAll()
    {
        SqlQuery query = new QueryBuilder(Import.TableName).Select().Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
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
        SqlQuery query = new QueryBuilder(Import.TableName)
                .Select()
                .Where("ImportID", ComparisonCondition.Equal, id)
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
        SqlQuery query = new QueryBuilder(Import.TableName)
           .Update(new Dictionary<string, object>
               {
                    {"ImportDate", entity.ImportDate },
                    {"TotalItem", entity.TotalItem },
                    {"TotalCost", entity.TotalCost },
                    {"HandledBy", entity.HandledBy },
                    {"SupplierID", entity.SupplierID },
               }
           ).Where("ProductID", ComparisonCondition.Equal, entity.ID).Build();


        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {

            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating Import > {ex.Message}");

            }


        }
    }
}
