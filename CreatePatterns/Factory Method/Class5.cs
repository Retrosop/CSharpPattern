﻿public abstract class Vehicle
{
	public abstract void Move();
}

public class Car : Vehicle
{
	public override void Move()
	{
		Console.WriteLine("Машина едет");
	}
}

public class Bus : Vehicle
{
	public override void Move()
	{
		Console.WriteLine("Автобус едет");
	}
}

public class Trum : Vehicle
{
	public override void Move()
	{
		Console.WriteLine("Трамвай едет");
	}
}