#define COL_MAPPING


using BayonFramework.Database.Driver;
using BayonFramework.Database;
using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;




namespace IMS_Services.Services.Implementation;

public class InventoryServices
{
    private static IDatabase db = Database.Instance.GetDatabase();
    private static SqlConnection connection = (SqlConnection)db.GetConnection()!;

    public const string INV_TB_NAME = "tbInventory";
    public const string INV_COL_ID = "InvID";
    public const string INV_COL_UNITCOST = "UnitCost";
    public const string INV_COL_EXPDATE = "ExpirationDate";
    public const string INV_COL_CURRSTOCK = "CurrentStock";
    public const string INV_COL_INITQTY = "InitialQty";
    public const string INV_COL_SUBT = "SubTotal";
    public const string INV_COL_NOTE = "Note";
    public const string INV_COL_LAST_UPDATE = "LastUpdate";
    public const string INV_COL_PRO_ID = "ProductID";
    public const string INV_COL_IMP_ID = "ImportID";
    public const string INV_COL_STATUS = "Status";

    public static DataRow AddRow(DataTable table, Inventory inv)
    {
        var row = table.NewRow();
        
        //row[INV_COL_ID] = inv.UnitCost;
        row[INV_COL_UNITCOST] = inv.UnitCost;
        row[INV_COL_EXPDATE] = inv.ExpirationDate;
        row[INV_COL_SUBT] = inv.SubTotal;
        row[INV_COL_INITQTY] = inv.InitialQty;
        row[INV_COL_CURRSTOCK] = inv.CurrentStock;
        row[INV_COL_NOTE] = inv.Note;
        row[INV_COL_LAST_UPDATE] = inv.LastUpdate;
        row[INV_COL_PRO_ID] = inv.ProductID;
        row[INV_COL_STATUS] = inv.GetStatusValue();
       
        return row;
    }

    public static SqlBulkCopy Submit(string tableName)
    {

        SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.FireTriggers, null);
        bulkCopy.DestinationTableName = tableName;

        #if COL_MAPPING
        // Map the columns in the source DataTable to the columns in the destination table
        
        bulkCopy.ColumnMappings.Add(INV_COL_UNITCOST, INV_COL_UNITCOST);
        bulkCopy.ColumnMappings.Add(INV_COL_EXPDATE, INV_COL_EXPDATE);
        bulkCopy.ColumnMappings.Add(INV_COL_CURRSTOCK, INV_COL_CURRSTOCK);
        bulkCopy.ColumnMappings.Add(INV_COL_INITQTY, INV_COL_INITQTY);
        bulkCopy.ColumnMappings.Add(INV_COL_SUBT, INV_COL_SUBT);
        bulkCopy.ColumnMappings.Add(INV_COL_LAST_UPDATE, INV_COL_LAST_UPDATE);
        bulkCopy.ColumnMappings.Add(INV_COL_PRO_ID, INV_COL_PRO_ID);
        bulkCopy.ColumnMappings.Add(INV_COL_NOTE, INV_COL_NOTE);
        bulkCopy.ColumnMappings.Add(INV_COL_IMP_ID, INV_COL_IMP_ID);
        bulkCopy.ColumnMappings.Add(INV_COL_STATUS, INV_COL_STATUS);

        #endif

        return bulkCopy;
        
    }

    public static void RetrieveData(DataTable table)
    {
        table.Rows.Clear();
     
        SqlQuery query = new QueryBuilder("tbInventory").Select().Build();
        SqlDataAdapter da = new SqlDataAdapter(query.Query, connection);
        da.Fill(table);
    }

    public static IEnumerable<Inventory> GetAll()
    {
        SqlQuery query = new QueryBuilder("tbInventory").Select().Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all inventory > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToInventory();
                }
            }
            reader?.Close();
        }
    }

    public static Inventory GetById(int id)
    {
        SqlQuery query = new QueryBuilder("tbInventory")
                .Select()
                .Where("InvID", ComparisonCondition.Equal, id)
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
                throw new Exception($"Error in getting Inventory with ID, {id} > {ex.Message}");
            }

            Inventory? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToInventory();
                }
            }

            reader?.Close();
            return result;

        }
    }

    public static bool Delete(int id)
    {
        SqlQuery query = new QueryBuilder("tbInventory").Delete().Where("InvID", ComparisonCondition.Equal, id).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {
            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting inventory > {ex.Message}");
            }
        }
    }

    public static bool Update(Inventory entity)
    {
        SqlQuery query = new QueryBuilder("tbInventory")
          .Update(new Dictionary<string, object>
              {
                    {"UnitCost", entity.UnitCost },
                    {"ExpirationDate", entity.ExpirationDate },
                    {"CurrentStock", entity.CurrentStock },
                    {"InitialQty", entity.InitialQty },
                    {"Note", entity.Note! },
                    {"SubTotal", entity.SubTotal },
                    {"LastUpdate", entity.LastUpdate },
                    {"ProductID", entity.ProductID },
                    {"ImportID", entity.ImportID },
                    {"Status", entity.GetStatusValue() },
              }
          ).Where("InvID", ComparisonCondition.Equal, entity.ID).Build();

        using (SqlCommand cmd = new SqlCommand(query.Query, connection))
        {

            try
            {
                int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating Inventory > {ex.Message}");

            }


        }
    }

 
}
