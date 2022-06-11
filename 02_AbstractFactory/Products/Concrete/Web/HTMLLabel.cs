namespace AbstractFactory.Products.Concrete.Web;

public class HTMLLabel : Label
{
	protected override void DoRender()
	{
		Console.WriteLine($"<label> {Text} </label>");
	}
}
