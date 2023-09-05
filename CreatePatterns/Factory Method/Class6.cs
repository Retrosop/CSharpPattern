﻿public interface IMovable
{
	void Move();
}

public abstract class Vehicle: IMovable
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

public class Hourse : IMovable
{
	public void Move() => Console.WriteLine("Лошадь скачет");
}