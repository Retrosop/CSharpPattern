
namespace ProxyExample;

internal class  Chief: IChief
{
    public IDictionary<int, string> GetStatuses ()
    {
        Dictionary<int, string> statuses = new Dictionary<int, string>();
        statuses.Add(1, "Ready");
        statuses.Add(2, "Wait");
        statuses.Add(3, "Stop");

        Thread.Sleep(2000);

        return statuses;
    }

    public IEnumerable<Order> GetOrders()
    {
        List<Order> orders = new List<Order>();
        orders.Add(new Order() { Name = "Burger", StatusId = RandomizeStatus() });
        orders.Add(new Order() { Name = "Pasta", StatusId = RandomizeStatus() });
        orders.Add(new Order() { Name = "Amlet", StatusId = RandomizeStatus() });

        return orders;

    }
    public static int RandomizeStatus() => new Random().Next(1,4);
}