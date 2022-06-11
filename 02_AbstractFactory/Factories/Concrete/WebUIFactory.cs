using AbstractFactory.Factories.Abstract;
using AbstractFactory.Products.Abstract;
using AbstractFactory.Products.Concrete.Web;

namespace AbstractFactory.Factories.Concrete;

public class WebUIFactory : UIFactory
{
	public override Button GetButton(string text) => new HTMLButton { Text = text };
	public override TextBox GetTextBox(string text = null) => new HTMLTextBox { Text = text };
	public override Label GetLabel(string text, ConsoleColor color) => new HTMLLabel { Text = text, Color = color };
}
