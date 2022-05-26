namespace AbstractFactory.Products;

public abstract class Button
{
	public string Text { get; init; }

	public abstract void Render();
}