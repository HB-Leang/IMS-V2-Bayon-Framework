using IMS_Services.EnumUtils;
using IMS_Services.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Entities;

public class Product 
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Barcode {  get; set; }
    public decimal SalePrice { get; set; }
    public EnumUOM UOM { get; set; }
    public short TotalStock { get; set; }
    public byte CategoryID { get; set; }

    public Product()
    {
        Console.WriteLine("Default Constructor Called");
    }
}
