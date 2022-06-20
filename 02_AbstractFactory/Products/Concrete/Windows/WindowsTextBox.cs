using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.Windows;

public class WindowsTextBox : TextBox
{
	public override void Render()
	{
		Console.WriteLine($"*TextBox* {Text} *TextBox*");
	}
}
