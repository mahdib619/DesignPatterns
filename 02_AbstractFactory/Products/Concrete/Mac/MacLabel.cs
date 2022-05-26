namespace AbstractFactory.Products.Mac;

public class MacLabel : Label
{
	protected override void DoRender()
	{
		Console.WriteLine($"#label# {Text} #label#");
	}
}