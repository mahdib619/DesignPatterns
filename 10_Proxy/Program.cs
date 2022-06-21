// Proxy pattern implementation is located in Main folder

var userService = new UserService();
var videoService = new VideoService(userService);

var menus = new Dictionary<string, IMenu>
{
	["0"] = new InvalidOptionMenu(),
	["1"] = new UserMenu(userService),
	["2"] = new VideoMenu(videoService),
	["3"] = new ExitMenu()
};

while (true)
{
	var option = ShowMainMenu();

	var menu = menus.GetValueOrDefault(option, menus["0"]);
	menu.Show();
}

string ShowMainMenu()
{
	var user = userService.GetCurrentUser();
	if (user is not null)
		Console.WriteLine($"Hello {user}\n");

	Console.WriteLine($"1-{(user is null ? "Login" : "Logout")}");
	Console.WriteLine("2-Videos");
	Console.WriteLine("3-Exit");
	Console.WriteLine();

	Console.Write("Option:");
	return Console.ReadLine();
}