using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class Product : IInfo
{
    public string Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Product(string id, string name, double price)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
    }
    public string Text
    {
        get
        {
            return string.Format("Id={0}, Name={1}, Price={2:C2}", Id, Name, Price);
        }
    }
    public string Type
    {
        get
        {
            return "Product";
        }
    }
}
