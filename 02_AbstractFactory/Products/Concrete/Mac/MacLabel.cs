using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.Mac;

public class MacLabel : Label
{
	protected override void DoRender()
	{
		Console.WriteLine($"#label# {Text} #label#");
	}
}
