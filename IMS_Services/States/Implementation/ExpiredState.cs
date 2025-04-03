using IMS_Services.Entities;

namespace IMS_Services.States.Implementation;

public class ExpiredState : IInventoryState
{
    public string GetStatus() => "Expired";

    public void UpdateState(Inventory inventory)
    {
        if (inventory.CurrentStock == 0)
            inventory.State = InventoryStates.GetState(2);
    }
}