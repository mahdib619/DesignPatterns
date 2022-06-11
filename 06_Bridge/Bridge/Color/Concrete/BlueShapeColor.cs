using Bridge.Bridge.Color.Abstract;

namespace Bridge.Bridge.Color.Concrete;

internal class BlueShapeColor : ShapeColor
{
	protected override ConsoleColor Color => ConsoleColor.Blue;
}
