namespace AbstractFactory.Products.Windows;

public class WindowsTextBox : TextBox
{
	public override void Render()
	{
		Console.WriteLine($"*TextBox* {Text} *TextBox*");
	}
}