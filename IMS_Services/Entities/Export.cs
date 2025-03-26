
namespace IMS_Services.Entities;

public class Export
{
    public int ID { get; set; }
    public DateTime ExportDate { get; set; }
    public short TotalItem { get; set; }
    public decimal TotalCost { get; set; }
    public short HandledBy { get; set; }

}
