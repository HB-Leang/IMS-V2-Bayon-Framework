using IMS_Services.Entities;

namespace IMS_Services.States.Implementation;

public class ActiveState : IInventoryState
{
    public string GetStatus() => "Active";

    public void UpdateState(Inventory inventory)
    {
        if (inventory.CurrentStock == 0)
            inventory.State = InventoryStates.GetState(2);
        else if (inventory.ExpirationDate < DateTime.Today)
            inventory.State = InventoryStates.GetState(1);
    }
}
