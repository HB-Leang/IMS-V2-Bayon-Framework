using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System.Data;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;

namespace IMS_Services.Services.Implementation;

public class SupplierServices : ICRUDServices<Supplier, byte>
{
    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;

    public static byte Add(Supplier entity)
    {
        SqlQuery query = new QueryBuilder(Supplier.TableName).Insert(
                new Dictionary<string, object>
                    {
                        {"SupplierName", entity.Name! },
                        {"Email", entity.Email! },
                        {"Phone", entity.Phone! },
                        {"Address", entity.Address! },
                        {"PaymentMethod", entity.PaymentMethod },
                        {"PaymentTerm", entity.PaymentTerm },
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
                throw new Exception($"Failed in adding new Staff > {ex.Message}");

            }
        }
    }

    public static bool Delete(byte id)
    {
        SqlQuery query = new QueryBuilder(Supplier.TableName).Delete().Where("StaffID", ComparisonCondition.Equal, id).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting Staff > {ex.Message}");

            }
        }
    }

    public static IEnumerable<Supplier> GetAll()
    {
        SqlQuery query = new QueryBuilder(Supplier.TableName).Select().Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = query.GetSqlCommand(cmd).ExecuteReader();
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
        SqlQuery query = new QueryBuilder(Supplier.TableName)
                .Select()
                .Where("SupplierID", ComparisonCondition.Equal, id)
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
        SqlQuery query = new QueryBuilder(Supplier.TableName)
               .Select()
               .Where("SupplierName", ComparisonCondition.Like, $"%{name}%")
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
                    yield return record.ToSupplier();
                }
            }
            reader?.Close();

        }
    }

    public static bool Update(Supplier entity)
    {
        SqlQuery query = new QueryBuilder(Supplier.TableName)
           .Update(new Dictionary<string, object>
               {
                    {"SupplierName", entity.Name! },
                    {"Email", entity.Email! },
                    {"Phone", entity.Phone! },
                    {"Address", entity.Address! },
                    {"PaymentMethod", entity.PaymentMethod },
                    {"PaymentTerm", entity.PaymentTerm },
               }
           ).Where("SupplierID", ComparisonCondition.Equal, entity.ID).Build();


        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating Staff > {ex.Message}");

            }
        }
    }
}
