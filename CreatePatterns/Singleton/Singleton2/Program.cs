﻿class Program
{
	static void Main(string[] args)
	{
		(new Thread(() =>
		{
			Computer comp2 = new Computer();
			comp2.OS = OS.getInstance("Windows 10");
			Console.WriteLine(comp2.OS.Name);

		})).Start();

		Computer comp = new Computer();
		comp.Launch("Windows 8.1");
		Console.WriteLine(comp.OS.Name);
		Console.ReadLine();
	}
}
class Computer
{
	public OS OS { get; set; }
	public void Launch(string osName)
	{
		OS = OS.getInstance(osName);
	}
}
class OS
{
	private static OS instance;

	public string Name { get; private set; }
	private static object syncRoot = new Object();

	protected OS(string name)
	{
		this.Name = name;
	}

	public static OS getInstance(string name)
	{
		if (instance == null)
		{
			lock (syncRoot)
			{
				if (instance == null)
					instance = new OS(name);
			}
		}
		return instance;
	}

}