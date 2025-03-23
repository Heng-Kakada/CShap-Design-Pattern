using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class Factory
{
    public string Name { get; set; }
    public int Workers { get; set; }
    public string Location { get; set; }
    public Factory(string name, int workers, string location)
    {
        this.Name = name;
        this.Workers = workers;
        this.Location = location;
    }
    public Factory() : this("", 0, "")
    {
    }
}
