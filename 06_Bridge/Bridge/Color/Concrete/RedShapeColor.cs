using Bridge.Bridge.Color.Abstract;

namespace Bridge.Bridge.Color.Concrete;

internal class RedShapeColor : ShapeColor
{
	protected override ConsoleColor Color => ConsoleColor.Red;
}
