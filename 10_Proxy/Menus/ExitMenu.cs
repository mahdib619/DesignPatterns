namespace Proxy.Menus;

public class ExitMenu : BaseMenu
{
	protected override void DoShow()
	{
		Environment.Exit(0);
	}
}
