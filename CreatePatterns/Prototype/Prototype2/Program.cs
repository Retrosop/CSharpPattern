using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
	static void Main(string[] args)
	{
		Circle figure = new Circle(30, 50, 60);
		Circle clonedFigure = figure.Clone() as Circle;
		figure.Point.X = 100; // изменяем координаты начальной фигуры
		figure.GetInfo(); // figure.Point.X = 100
		clonedFigure.GetInfo(); // clonedFigure.Point.X = 100

		Console.Read();
	}
}

