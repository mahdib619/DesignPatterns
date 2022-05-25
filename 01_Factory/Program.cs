using Factory;

var UserInterfaces = new Dictionary<string, UserInterface>
{
	["1"] = new WindowsUI(),
	["2"] = new WebUI()
};

while (true)
{
	Console.WriteLine("1-Windows");
	Console.WriteLine("2-Web");
	Console.Write("Choose Ui: ");

	var option = Console.ReadLine();
	
	if(UserInterfaces.TryGetValue(option, out var userInterface))
	{
		userInterface.Start();
		userInterface.ShotDown();
	}
	else
	{
		Console.WriteLine("Invalid option!");
		Console.Write("press any key to continue...");
		Console.ReadKey();
		Console.Clear();
	}
}