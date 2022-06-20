using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.Web;

public class HTMLButton : Button
{
	public override void Render()
	{
		Console.WriteLine($"<button> {Text} </button>");
	}
}
