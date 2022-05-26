using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public abstract class UIFactory
{
	public abstract Button GetButton(string text);
	public abstract TextBox GetTextBox(string text = null);
	public abstract Label GetLabel(string text, ConsoleColor color);
}
