using Bridge.NonBridge.Abstract;
using Bridge.NonBridge.ColorShape.Abstract;

namespace Bridge.NonBridge.ColorShape.Concrete.Rectangle;

internal class BlueRectangle : IShape1
{
	public void Draw()
	{
		var dc = Console.ForegroundColor;

		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("A Rectangle");

		Console.ForegroundColor = dc;
	}
}
