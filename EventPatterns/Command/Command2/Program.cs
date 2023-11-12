class Program
{
	static void Main(string[] args)
	{
		Pult pult = new Pult();
		TV tv = new TV();
		pult.SetCommand(new TVOnCommand(tv));
		pult.PressButton();
		pult.PressUndo();

		Microwave microwave = new Microwave();
		// 5000 - время нагрева пищи
		pult.SetCommand(new MicrowaveCommand(microwave, 5000));
		pult.PressButton();

		Console.Read();
	}
}