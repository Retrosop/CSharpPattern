using System.Diagnostics.Metrics;

class Program
{
	static void Main(string[] args)
	{
		Programmer programmer = new Programmer();
		Tester tester = new Tester();
		Marketolog marketolog = new Marketolog();

		List<ICommand> commands = new List<ICommand>
		{
			new CodeCommand(programmer),
			new TestCommand(tester),
			new AdvertizeCommand(marketolog)
		};
		Manager manager = new Manager();
		manager.SetCommand(new MacroCommand(commands));
		manager.StartProject();
		manager.StopProject();

		Console.Read();
	}
}