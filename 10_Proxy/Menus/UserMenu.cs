namespace Proxy.Menus;

public class UserMenu : BaseMenu
{
	private readonly IUserService _userService;

	public UserMenu(IUserService userService)
	{
		_userService = userService;
	}

	protected override void DoShow()
	{
		var user = _userService.GetCurrentUser();
		if (user is not null)
		{
			_userService.Logout();
			Console.WriteLine("Logged out successfully.");
			return;
		}

		Console.Write("Username:");
		var userName = Console.ReadLine();

		Console.Write("Password:");
		var password = Console.ReadLine();

		var success = _userService.Login(userName, password);
		if (success)
			Console.WriteLine("Logged in successfully.");
		else
			Console.WriteLine("Invalid username or password!");
	}
}
