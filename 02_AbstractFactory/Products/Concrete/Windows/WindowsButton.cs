namespace AbstractFactory.Products.Windows;

public class WindowsButton : Button
{
	public override void Render()
	{
		Console.WriteLine($"*Button* {Text} *Button*");
	}
}