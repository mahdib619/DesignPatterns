using Bridge.NonBridge.Abstract;
using Bridge.NonBridge.ColorShape.Abstract;

namespace Bridge.NonBridge.ColorShape.Concrete.Square;

internal class RedSquare : IShape1
{
	public void Draw()
	{
		var dc = Console.ForegroundColor;

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("A Square");

		Console.ForegroundColor = dc;
	}
}
