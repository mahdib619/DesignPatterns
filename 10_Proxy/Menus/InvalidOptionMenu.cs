namespace Proxy.Menus;

public class InvalidOptionMenu : BaseMenu
{
	protected override void DoShow()
	{
		Console.Write("Invalid option! ");
	}
}
