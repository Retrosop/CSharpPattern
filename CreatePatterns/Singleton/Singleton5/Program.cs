class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine($"Main {DateTime.Now.TimeOfDay}");
		Console.WriteLine(Singleton.text);
	}
}
