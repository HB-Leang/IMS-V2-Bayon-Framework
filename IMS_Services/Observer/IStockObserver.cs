using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Observer;

public interface IStockObserver
{
    void OnLowStock(string message);
}
