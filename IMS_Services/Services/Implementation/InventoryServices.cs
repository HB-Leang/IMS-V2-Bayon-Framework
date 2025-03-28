#define COL_MAPPING


using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;




namespace IMS_Services.Services.Implementation;

public class InventoryServices
{
    private static DatabaseConnection connection = DatabaseConnection.Instance;

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
       
        return row;
    }

    public static SqlBulkCopy Submit(string tableName)
    {

        SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.GetConnection(), SqlBulkCopyOptions.FireTriggers, null);
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

#endif

        return bulkCopy;
        
    }

    public static void RetrieveData(DataTable table)
    {
        table.Rows.Clear();
        string read_query = "SELECT * FROM tbInventory";
        SqlDataAdapter da = new SqlDataAdapter(read_query, connection.GetConnection());
        da.Fill(table);
    }

    public static IEnumerable<Inventory> GetAll()
    {
        string query = "SELECT * FROM tbInventory";

        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
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
        string query = "SELECT * FROM tbInventory WHERE InvID = " + id;
        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
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
        string query = "DELETE FROM tbInventory WHERE InvID = @id;";

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
                throw new Exception($"Failed in deleting inventory > {ex.Message}");
            }
        }
    }

    public static bool Update(Inventory entity)
    {
        string query = @"
        UPDATE tbInventory
        SET 
            UnitCost = @uc,
            ExpirationDate = @ed,
            CurrentStock = @cs,
            InitialQty = @iq,
            Note = @n,
            SubTotal = @st,
            LastUpdate = @lu,
            ProductID = @pid,
            ImportID = @im

        WHERE 
            InvID = @id;";


        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            cmd.Parameters.AddWithValue("@uc", entity.UnitCost);
            cmd.Parameters.AddWithValue("@ed", entity.ExpirationDate);
            cmd.Parameters.AddWithValue("@cs", entity.CurrentStock);
            cmd.Parameters.AddWithValue("@iq", entity.InitialQty);
            cmd.Parameters.AddWithValue("@n", entity.Note);
            cmd.Parameters.AddWithValue("@st", entity.SubTotal);
            cmd.Parameters.AddWithValue("@lu", entity.LastUpdate);
            cmd.Parameters.AddWithValue("@pid", entity.ProductID);
            cmd.Parameters.AddWithValue("@im", entity.ImportID);

            cmd.Parameters.AddWithValue("@id", entity.ID);

            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating new Inventory > {ex.Message}");

            }


        }
    }

 
}
