using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS_Services.Entities;

namespace IMS_Services.States;

public interface IInventoryState
{
    string GetStatus();
    bool CanBeExported();
    void UpdateState(Inventory inventory);
}
