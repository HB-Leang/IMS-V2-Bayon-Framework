using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Entities;

public class Category
{
    public static string TableName = "tbCategory";
    public byte ID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
