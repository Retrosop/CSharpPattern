public interface IMovable
{
	void Move();
}

public class Car: IMovable
{
	public void Move()
	{
		Console.Writeline("Машина едет");
	}
}
