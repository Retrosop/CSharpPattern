namespace App1;

class Program
{
    static void Main(string[] args)
    {
        Stock stock = new Stock();

        Bank bank = new Bank("Уралсиб", stock);
        Broker broker = new Broker("Иван Иваныч", stock);

        Broker broker1 = new Broker("Семен Семеныч", stock);

        stock.Market();
        broker.StopTrade();

        stock.Market();


        stock.Market();
        broker1.StopTrade();

        Console.Read();

    }

}




interface IObserver
{
    void Update(Object ob);
}

class StockInfo
{
    public int USD { get; set; }
    public int Euro { get; set; }

}

class Bank : IObserver
{
    public string Name { get; set; }

    IObserbvable stock;

    public Bank(string name, IObserbvable obs)
    {
        this.Name = name;
        stock = obs;
        stock.RegisterObserver(this);
    }

    public void Update(object ob)
    {
        StockInfo sInfo = (StockInfo)ob;

        if (sInfo.USD > 40)
            Console.WriteLine("Банк {0} продает доллары; Курс {1}", this.Name, sInfo.USD);
        else
            Console.WriteLine("Банк {0} покупает доллары; Курс {1}", this.Name, sInfo.USD);
    }

    public void StopTrade()
    {
        stock.RemoveObserver(this);
        stock = null;
    }
}

    class Broker : IObserver
{
    public string Name { get; set; }

    IObserbvable stock;

    public Broker(string name, IObserbvable obs)
    {
        this.Name = name;
        stock = obs;
        stock.RegisterObserver(this);
    }

    public void Update( object ob)
    {
        StockInfo sInfo = (StockInfo)ob;

        if (sInfo.USD > 30)
            Console.WriteLine("Брокер {0} продает доллары; Курс {1}", this.Name, sInfo.USD);
        else
            Console.WriteLine("Брокер {0} покупает доллары; Курс {1}", this.Name, sInfo.USD);
    }

    public void StopTrade()
    {
        stock.RemoveObserver(this);
        stock = null;
    }
}