using Proxy.Helpers;

namespace Proxy.Menus.Abstract;

public abstract class BaseMenu : IMenu
{
	public void Show()
	{
		Console.Clear();

		DoShow();

		ConsoleHelper.WriteAndWaitForAnyKey("");
		Console.Clear();
	}

	protected abstract void DoShow();
}
