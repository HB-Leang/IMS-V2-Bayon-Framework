namespace IMS_Services.Entities;

public class Inventory
{
    public int ID {get; set; }
    public decimal UnitCost { get; set; }
    public DateTime ExpirationDate { get; set; }
    public short CurrentStock { get; set; }
    public short InitialQty { get; set; }
    public decimal SubTotal { get; set; }
    public int ProductID { get; set; }
    public int ImportID { get; set; }
    public string? Note { get; set; }
    public DateTime LastUpdate {  get; set; }
}
