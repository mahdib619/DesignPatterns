namespace AbstractFactory.Products.Concrete.Windows;

public class WindowsButton : Button
{
	public override void Render()
	{
		Console.WriteLine($"*Button* {Text} *Button*");
	}
}
