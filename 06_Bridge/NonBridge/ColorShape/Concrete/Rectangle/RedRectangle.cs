using Bridge.NonBridge.Abstract;
using Bridge.NonBridge.ColorShape.Abstract;

namespace Bridge.NonBridge.ColorShape.Concrete.Rectangle;

internal class RedRectangle : IShape1
{
	public void Draw()
	{
		var dc = Console.ForegroundColor;

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("A Rectangle");

		Console.ForegroundColor = dc;
	}
}
