using AbstractFactory.Products;
using AbstractFactory.Products.Mac;

namespace AbstractFactory.Factories;

public class MacUIFactory : UIFactory
{
	public override Button GetButton(string text) => new MacButton { Text = text };
	public override TextBox GetTextBox(string text = null) => new MacTextBox { Text = text };
	public override Label GetLabel(string text, ConsoleColor color) => new MacLabel { Text = text, Color = color };
}
