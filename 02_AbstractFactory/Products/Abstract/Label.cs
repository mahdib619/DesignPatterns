namespace AbstractFactory.Products.Abstract;

public abstract class Label
{
	public string Text { get; set; }
	public ConsoleColor Color { get; init; }

	public void Render()
	{
		var originalColor = Console.BackgroundColor;
		Console.BackgroundColor = Color;

		DoRender();

		Console.BackgroundColor = originalColor;
	}

	protected abstract void DoRender();
}
