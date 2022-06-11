using AbstractFactory.Factories.Abstract;
using AbstractFactory.Products.Abstract;
using AbstractFactory.Products.Concrete.Windows;

namespace AbstractFactory.Factories.Concrete;

public class WindowsUIFactory : UIFactory
{
	public override Button GetButton(string text) => new WindowsButton { Text = text };
	public override TextBox GetTextBox(string text = null) => new WindowsTextBox { Text = text };
	public override Label GetLabel(string text, ConsoleColor color) => new WindowsLabel { Text = text, Color = color };
}
