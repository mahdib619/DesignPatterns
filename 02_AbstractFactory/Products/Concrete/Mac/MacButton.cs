namespace AbstractFactory.Products.Concrete.Mac;

public class MacButton : Button
{
	public override void Render()
	{
		Console.WriteLine($"#button# {Text} #button#");
	}
}
