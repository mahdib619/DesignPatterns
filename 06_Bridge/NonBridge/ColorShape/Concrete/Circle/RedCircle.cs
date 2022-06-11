using Bridge.NonBridge.Abstract;
using Bridge.NonBridge.ColorShape.Abstract;

namespace Bridge.NonBridge.ColorShape.Concrete.Circle;

internal class RedCircle : IShape1
{
	public void Draw()
	{
		var dc = Console.ForegroundColor;

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("A Circle");

		Console.ForegroundColor = dc;
	}
}
