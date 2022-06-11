using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Factories.Abstract;

public abstract class UIFactory
{
	public abstract Button GetButton(string text);
	public abstract TextBox GetTextBox(string text = null);
	public abstract Label GetLabel(string text, ConsoleColor color);
}
