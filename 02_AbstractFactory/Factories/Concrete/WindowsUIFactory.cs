using AbstractFactory.Products;
using AbstractFactory.Products.Windows;

namespace AbstractFactory.Factories;

public class WindowsUIFactory : UIFactory
{
	public override Button GetButton(string text) => new WindowsButton { Text = text };
	public override TextBox GetTextBox(string text = null) => new WindowsTextBox { Text = text };
	public override Label GetLabel(string text, ConsoleColor color) => new WindowsLabel { Text = text, Color = color };
}
