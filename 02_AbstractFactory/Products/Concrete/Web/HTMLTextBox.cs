namespace AbstractFactory.Products.Concrete.Web;

public class HTMLTextBox : TextBox
{
	public override void Render()
	{
		Console.WriteLine($"<input type=\"text\" value=\"{Text}\"/>");
	}
}
