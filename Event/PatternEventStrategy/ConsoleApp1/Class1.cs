namespace App1;

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