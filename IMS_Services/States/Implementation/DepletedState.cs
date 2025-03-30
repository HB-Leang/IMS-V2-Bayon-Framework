using IMS_Services.Entities;

namespace IMS_Services.States.Implementation;

public class DepletedState : IInventoryState
{
    public bool CanBeExported() => false;
    public string GetStatus() => "Depleted";

    public void UpdateState(Inventory inventory)
    {
        if (inventory.CurrentStock == 0) return;


        if (inventory.ExpirationDate > DateTime.Today)
            inventory.State = InventoryStates.GetState(1);
        else
            inventory.State = InventoryStates.GetState(0);
    }
}
