using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System.Data;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;


namespace IMS_Services.Services.Implementation;

public class StaffServices : ICRUDServices<Staff, short>
{

    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;


    public static short Add(Staff staff)
    {
        SqlQuery query = new QueryBuilder(Staff.TableName).Insert(
               new Dictionary<string, object>
                   {
                        {"StaffName", staff.StaffName! },
                        {"Gender", staff.Gender },
                        {"BirthDate", staff.BirthDate },
                        {"StaffPosition", staff.StaffPosition! },
                        {"Address", staff.Address! },
                        {"WorkNumber", staff.WorkNumber! },
                        {"PersonalNumber", staff.PersonalNumber! },
                        {"HiredDate", staff.HiredDate },
                        {"Salary", staff.Salary },
                        {"StoppedWork", staff.StoppedWork },
                   }
               ).Build();

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
        SqlQuery query = new QueryBuilder(Staff.TableName).Delete().Where("StaffID", ComparisonCondition.Equal, id).Build();

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

    public static IEnumerable<Staff> GetAll()
    {
        SqlQuery query = new QueryBuilder(Staff.TableName).Select().Build();

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
                        yield return record.ToStaff();
                    }
                }
                reader?.Close();
            
        }
    }

    public static Staff GetById(short id)
    {
        SqlQuery query = new QueryBuilder(Staff.TableName)
                .Select()
                .Where("StaffID", ComparisonCondition.Equal, id)
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
        SqlQuery query = new QueryBuilder(Staff.TableName)
               .Select()
               .Where("StaffName", ComparisonCondition.Like, $"%{name}%")
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
                        yield return record.ToStaff();
                    }
                }
                reader?.Close();
            
        }
    }

    public static bool Update(Staff staff)
    {
        SqlQuery query = new QueryBuilder(Staff.TableName)
           .Update(new Dictionary<string, object>
               {
                    {"StaffName", staff.StaffName! },
                    {"Gender", staff.Gender },
                    {"BirthDate", staff.BirthDate },
                    {"StaffPosition", staff.StaffPosition! },
                    {"Address", staff.Address! },
                    {"WorkNumber", staff.WorkNumber! },
                    {"PersonalNumber", staff.PersonalNumber! },
                    {"HiredDate", staff.HiredDate },
                    {"Salary", staff.Salary },
                    {"StoppedWork", staff.StoppedWork },
               }
           ).Where("StaffID", ComparisonCondition.Equal, staff.StaffId).Build();


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
