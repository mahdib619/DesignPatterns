using Bridge.NonBridge.Abstract;
using Bridge.NonBridge.ColorShape.Abstract;

namespace Bridge.NonBridge.ColorShape.Concrete.Rectangle;

internal class GreenRectangle : IShape1
{
	public void Draw()
	{
		var dc = Console.ForegroundColor;

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("A Rectangle");

		Console.ForegroundColor = dc;
	}
}
