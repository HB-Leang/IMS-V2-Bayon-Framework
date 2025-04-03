using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System.Data;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;

namespace IMS_Services.Services.Implementation;

public class ProductServices : ICRUDServices<Product, int>
{
    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;
    public static int Add(Product product)
    {
        SqlQuery query = new QueryBuilder("tbProduct").Insert(
                new Dictionary<string, object>
                    {
                        {"ProductName", product.Name! },
                        {"Barcode", product.Barcode! },
                        {"SalePrice", product.SalePrice },
                        {"UOM", product.UOM },
                        {"TotalStock", product.TotalStock },
                        {"CategoryID", product.CategoryID },
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
                throw new Exception($"Failed in adding new product > {ex.Message}");

            }
        }
    }

    public static bool Delete(int id)
    {
        SqlQuery query = new QueryBuilder(Product.TableName).Delete().Where("ProductID", ComparisonCondition.Equal, id).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting product > {ex.Message}");
            }
        }
    }
    
    public static IEnumerable<Product> GetAll()
    {
        SqlQuery query = new QueryBuilder(Product.TableName).Select().Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = query.GetSqlCommand(cmd).ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all products > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToProduct();
                }
            }
            reader?.Close();

        }
    }

    public static Product GetById(int id)
    {
        SqlQuery query = new QueryBuilder(Product.TableName)
                .Select()
                .Where("ProductID", ComparisonCondition.Equal, id)
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
                throw new Exception($"Error in getting product with ID, {id} > {ex.Message}");
            }

            Product? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToProduct();
                }
            }

            reader?.Close();
            return result;

        }
    }

    public static IEnumerable<Product> GetLowStockProducts()
    {
        SqlQuery query = new QueryBuilder(Product.TableName).Select().Where("TotalStock", ComparisonCondition.LessThan, 6).Build();
        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = query.GetSqlCommand(cmd).ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting products with low stock > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return new Product()
                    {
                        ID = reader.GetInt32("ProductID"),
                        Name = reader.GetString("ProductName"),
                        TotalStock = reader.GetInt16("TotalStock"),
                    };
                }
            }
            reader?.Close();
        }
    }

    public static IEnumerable<Product> GetByName(string name)
    {
        SqlQuery query = new QueryBuilder(Product.TableName)
               .Select()
               .Where("ProductName", ComparisonCondition.Like, $"%{name}%")
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
                throw new Exception($"Error in getting Product with name, {name} > {ex.Message}");
            }
            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToProduct();
                }
            }
            reader?.Close();

        }
    }

    public static bool Update(Product product)
    {
        SqlQuery query = new QueryBuilder(Product.TableName)
           .Update(new Dictionary<string, object>
               {
                    {"ProductName", product.Name! },
                    {"Barcode", product.Barcode! },
                    {"SalePrice", product.SalePrice },
                    {"UOM", product.UOM },
                    {"TotalStock", product.TotalStock },
                    {"CategoryID", product.CategoryID },
               }
           ).Where("ProductID", ComparisonCondition.Equal, product.ID).Build();


        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating Product > {ex.Message}");

            }


        }
    }

   
    
}
