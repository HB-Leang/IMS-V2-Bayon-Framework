using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS_Services.States.Implementation;

namespace IMS_Services.States;

public static class InventoryStates
{
    private static readonly Dictionary<int, IInventoryState> States = new()
    {
        { 0, new ActiveState() }, // Active
        { 1, new ExpiredState() }, // Expired
        { 2, new DepletedState() } // Depleted
    };

    public static IInventoryState GetState(byte status) => States.TryGetValue(status, out var state) ? state : States[0];


}
