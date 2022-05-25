namespace Factory;

//creator
public abstract class UserInterface
{
	public void Start()
	{
		Console.WriteLine("Application started...");
		RenderElements();
		Console.Write("Press any key to exit.");
		Console.ReadKey();
	}
	
	public void ShotDown()
	{
		Console.Clear();
	}
	
	private void RenderElements()
	{
		GetButton().Render("Click");
	}

	protected abstract Button GetButton();
}

//concrete creator
public class WindowsUI : UserInterface
{
	protected override Button GetButton() => new WindowsButton();
}

//concrete creator
public class WebUI : UserInterface
{
	protected override Button GetButton() => new WebButton();
}

//product
public abstract class Button
{
	public abstract void Render(string text);
}

//concrete product
public class WindowsButton : Button
{
	public override void Render(string text) => Console.WriteLine($"*Button* {text} *Button*");
}

//concrete product
public class WebButton : Button
{
	public override void Render(string text) => Console.WriteLine($"<button>{text}</button>");
}