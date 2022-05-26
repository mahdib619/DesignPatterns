namespace AbstractFactory.Products;

public abstract class TextBox
{
	public string Text { get; set; }

	public abstract void Render();
}