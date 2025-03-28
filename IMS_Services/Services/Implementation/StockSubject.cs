using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS_Services.Entities;

namespace IMS_Services.Services.Implementation;

public class StockSubject
{
    public event EventHandler<Product>? StockLow;
    private List<IStockObserver> observers = new List<IStockObserver>();

    public void Attach(IStockObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IStockObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObserver(string totalStock)
    {
        foreach (var observer in observers)
        {
            observer.OnLowStock(totalStock);
        }
    }
}
