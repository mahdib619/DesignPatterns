using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.Windows;

public class WindowsLabel : Label
{
	protected override void DoRender()
	{
		Console.WriteLine($"*Label* {Text} *Label*");
	}
}
