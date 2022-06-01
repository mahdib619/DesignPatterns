namespace Prototype;

public abstract class Shape
{
	public Shape(){}

	public Shape(Shape source)
	{
		X = source.X;
		Y = source.Y;
		Color = source.Color;
	}

	public int X { get; set; }
	public int Y { get; set; }
	public string Color { get; set; }

	public abstract Shape Clone();
}
