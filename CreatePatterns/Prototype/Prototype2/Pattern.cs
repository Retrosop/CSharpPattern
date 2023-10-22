
interface IFigure
{
	IFigure Clone();
	void GetInfo();
}
class Point
{
	public int X { get; set; }
	public int Y { get; set; }
}
class Circle : IFigure
{
	int radius;
	public Point Point { get; set; }
	public Circle(int r, int x, int y)
	{
		radius = r;
		this.Point = new Point { X = x, Y = y };
	}

	public IFigure Clone()
	{
		return this.MemberwiseClone() as IFigure;
	}
	public void GetInfo()
	{
		Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", radius, Point.X, Point.Y);
	}
}