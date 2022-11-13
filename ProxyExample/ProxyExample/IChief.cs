using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample;

internal interface IChief
{
    IDictionary<int, string> GetStatuses();
    IEnumerable<Order> GetOrders();

}
