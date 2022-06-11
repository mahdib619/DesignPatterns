using Bridge.NonBridge.Abstract;
using Bridge.NonBridge.ColorShape.Abstract;

namespace Bridge.NonBridge.ColorShape.Concrete.Square;

internal class GreenSquare : IShape1
{
	public void Draw()
	{
		var dc = Console.ForegroundColor;

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("A Square");

		Console.ForegroundColor = dc;
	}
}
