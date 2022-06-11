using Bridge.Bridge.Color.Abstract;
using Bridge.NonBridge.Abstract;

namespace Bridge.Bridge.Shape.Concrete;

internal class Rectangle : IShape2
{
	private readonly ShapeColor _color;//bridge

	public Rectangle(ShapeColor color)
	{
		_color = color;
	}

	public void Draw()
	{
		_color.Start();
		Console.WriteLine("A Rectangle");
		_color.End();
	}
}
