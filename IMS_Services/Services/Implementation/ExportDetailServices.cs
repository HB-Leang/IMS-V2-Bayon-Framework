#define COL_MAPPING

using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;

using System.Data;


namespace IMS_Services.Services.Implementation;


public class ExportDetailServices
{


    private static DatabaseConnection connection = DatabaseConnection.Instance;

    public const string EXPD_TB_NAME = "tbExportDetail";
    public const string EXPD_COL_ID = "ExportDetailID";
    public const string EXPD_COL_QTYEXP = "QtyExported";
    public const string EXPD_COL_UNITPRICE = "UnitPrice";
    public const string EXPD_COL_STOTAL = "SubTotal";
    public const string EXPD_COL_EXPID = "ExportID";
    public const string EXPD_COL_PROID = "ProductID";
    public const string EXPD_COL_INVID = "InvID";

    public static DataRow AddRow(DataTable table, ExportDetail expDetail)
    {
        var row = table.NewRow();

        row[EXPD_COL_QTYEXP] = expDetail.QtyExported;
        row[EXPD_COL_UNITPRICE] = expDetail.UnitPrice;
        row[EXPD_COL_STOTAL] = expDetail.SubTotal;
        row[EXPD_COL_PROID] = expDetail.ProductID;
        row[EXPD_COL_INVID] = expDetail.InvID;
   

        return row;
    }

    public static SqlBulkCopy Submit(string tableName)
    {

        SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.GetConnection(), SqlBulkCopyOptions.FireTriggers, null);

        bulkCopy.DestinationTableName = tableName;

#if COL_MAPPING
        // Map the columns in the source DataTable to the columns in the destination table
        
        bulkCopy.ColumnMappings.Add(EXPD_COL_QTYEXP, EXPD_COL_QTYEXP);
        bulkCopy.ColumnMappings.Add(EXPD_COL_UNITPRICE, EXPD_COL_UNITPRICE);
        bulkCopy.ColumnMappings.Add(EXPD_COL_STOTAL, EXPD_COL_STOTAL);
        bulkCopy.ColumnMappings.Add(EXPD_COL_PROID, EXPD_COL_PROID);
        bulkCopy.ColumnMappings.Add(EXPD_COL_INVID, EXPD_COL_INVID);
        bulkCopy.ColumnMappings.Add(EXPD_COL_EXPID, EXPD_COL_EXPID);

#endif

        return bulkCopy;

    }
    public static ExportDetail GetById(int id)
    {
        string query = "SELECT * FROM tbExportDetail WHERE ExportDetailID = " + id;
        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting ExportDetail with ID, {id} > {ex.Message}");
            }

            ExportDetail? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToExportDetail();
                }
            }

            reader?.Close();
            return result;

        }
    }

    public static bool Delete(int id)
    {
        string query = "DELETE FROM tbExportDetail WHERE ExportDetailID = @id;";

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
                throw new Exception($"Failed in deleting export detail > {ex.Message}");
            }
        }
    }
    public static bool Update(ExportDetail entity)
    {
        string query = @"
        UPDATE tbExportDetail
        SET 
            UnitPrice = @up,
            QtyExported = @qtye,
            SubTotal = @st,
            ExportId = @expid,
            ProductID = @pid,
            InvID = @invid

        WHERE 
            ExportDetailID = @id;";


        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            cmd.Parameters.AddWithValue("@up", entity.UnitPrice);
            cmd.Parameters.AddWithValue("@qtye", entity.QtyExported);
            cmd.Parameters.AddWithValue("@st", entity.SubTotal);
            cmd.Parameters.AddWithValue("@expid", entity.ExportID);
            cmd.Parameters.AddWithValue("@pid", entity.ProductID);
            cmd.Parameters.AddWithValue("@invid", entity.InvID);


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
    public static void RetrieveData(DataTable table)
    {
        table.Rows.Clear();
        string read_query = "SELECT * FROM tbExportDetail";
        SqlDataAdapter da = new SqlDataAdapter(read_query, connection.GetConnection());
        da.Fill(table);


    }

}
