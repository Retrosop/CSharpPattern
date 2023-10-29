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




