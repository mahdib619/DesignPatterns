using Bridge.Bridge.Color.Abstract;

namespace Bridge.Bridge.Color.Concrete;

internal class GreenShapeColor : ShapeColor
{
	protected override ConsoleColor Color => ConsoleColor.Green;
}
