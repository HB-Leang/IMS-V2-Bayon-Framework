using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS_Services.Entities;
using IMS_Services.Services.Implementation;

namespace IMS_Services.Observer.Subject;

public class StockSubject
{
    private List<IStockObserver> observers = new List<IStockObserver>();

    public void Attach(IStockObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IStockObserver observer)
    {
        observers.Remove(observer);
    }

    public void CheckStockLevels()
    {
        string message = "Stocks are normal.";
        var products = ProductServices.GetLowStockProducts();
        if (products != null && products.Count() > 0)
        {
            message = "The following products are low on stock:\n\n";
            foreach (var product in products)
            {
                message += $"{product.Name}: {product.TotalStock} units remaining\n";
            }
        }

        
        NotifyObserver(message);
    }

    private void NotifyObserver(string message)
    {
        foreach (var observer in observers)
        {
            observer.OnLowStock(message);
        }
    }
}
