using IMS_Services.States;
using IMS_Services.States.Implementation;

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
    public IInventoryState? State { get; set; } = InventoryStates.GetState(0);
    public void UpdateStatus()
    {
        State?.UpdateState(this);
    }
    public byte GetStatusValue()
    {
        return State switch
        {
            ActiveState => 0,
            ExpiredState => 1,
            DepletedState => 2,
            _ => 0 // Default to Active
        };
    }
}
