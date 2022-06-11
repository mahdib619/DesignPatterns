using AbstractFactory.Factories.Abstract;
using AbstractFactory.Products.Abstract;
using AbstractFactory.Products.Concrete.Mac;

namespace AbstractFactory.Factories.Concrete;

public class MacUIFactory : UIFactory
{
	public override Button GetButton(string text) => new MacButton { Text = text };
	public override TextBox GetTextBox(string text = null) => new MacTextBox { Text = text };
	public override Label GetLabel(string text, ConsoleColor color) => new MacLabel { Text = text, Color = color };
}
