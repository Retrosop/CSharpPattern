using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
	static void Main(string[] args)
	{
		Circle figure = new Circle(30, 50, 60);
		// применяем глубокое копирование
		Circle clonedFigure = figure.DeepCopy() as Circle;
		figure.Point.X = 100;
		figure.GetInfo();
		clonedFigure.GetInfo();

		Console.Read();
	}
}
