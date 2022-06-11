using Bridge.Bridge.Color.Abstract;
using Bridge.NonBridge.Abstract;

namespace Bridge.Bridge.Shape.Concrete;

internal class Circle : IShape2
{
	private readonly ShapeColor _color;//bridge

	public Circle(ShapeColor color)
	{
		_color = color;
	}

	public void Draw()
	{
		_color.Start();
		Console.WriteLine("A Circle");
		_color.End();
	}
}
