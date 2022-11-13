using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample;

public struct Order
{
    public Guid Id { get; set; }  = Guid.NewGuid();
    public string? Name { get; set; } = null;
    public int StatusId { get; set; } = 0;
    public Order()
    {

    }
}
