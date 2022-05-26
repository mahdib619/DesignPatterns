namespace AbstractFactory.Products.Web;

public class HTMLButton : Button
{
	public override void Render()
	{
		Console.WriteLine($"<button> {Text} </button>");
	}
}