namespace App1;

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

	public void Update(object ob)
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

interface IObserbvable
{
  void RegisterObserver(IObserver o);
  void RemoveObserver(IObserver o);
  void NotifyObserver();

}

class Stock: IObserbvable
{
    StockInfo sInfo;
    List<IObserver> observers;

    public Stock()
    {
        observers = new List<IObserver>();
        sInfo = new StockInfo();

    }

    public void RegisterObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void NotifyObserver()
    {
        foreach (IObserver observer in observers)
            observer.Update(sInfo);
    }

    public void Market()
    {
        Random rnd = new Random();
        sInfo.USD = rnd.Next(20,40);
        sInfo.Euro = rnd.Next(30, 50);
        NotifyObserver();
    }

}