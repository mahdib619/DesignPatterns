namespace AbstractFactory.Products.Mac;

public class MacTextBox : TextBox
{
	public override void Render()
	{
		Console.WriteLine("#textbox# {Text} #textbox#");
	}
}