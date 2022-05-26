namespace AbstractFactory.Products.Windows;

public class WindowsLabel : Label
{
	protected override void DoRender()
	{
		Console.WriteLine($"*Label* {Text} *Label*");
	}
}