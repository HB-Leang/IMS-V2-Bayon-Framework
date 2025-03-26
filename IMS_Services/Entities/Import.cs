

namespace IMS_Services.Entities;

public class Import
{
    public int ID { get; set; }
    public DateTime ImportDate { get; set; }
    public decimal TotalCost { get; set; }
    public short TotalItem { get; set; }
    public short HandledBy { get; set; }
    public byte SupplierID { get; set; }
}
