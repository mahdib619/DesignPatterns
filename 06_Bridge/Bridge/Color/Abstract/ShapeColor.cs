namespace Bridge.Bridge.Color.Abstract;

internal abstract class ShapeColor
{
	protected abstract ConsoleColor Color { get; }
	private ConsoleColor _defaultColor;

	public void Start()
	{
		_defaultColor = Console.ForegroundColor;
		Console.ForegroundColor = Color;
	}

	public void End()
	{
		Console.ForegroundColor = _defaultColor;
	}
}
