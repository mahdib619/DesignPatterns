using Bridge.Bridge.Color.Abstract;
using Bridge.NonBridge.Abstract;

namespace Bridge.Bridge.Shape.Concrete;

internal class Square : IShape2
{
	private readonly ShapeColor _color;//bridge

	public Square(ShapeColor color)
	{
		_color = color;
	}

	public void Draw()
	{
		_color.Start();
		Console.WriteLine("A Square");
		_color.End();
	}
}
