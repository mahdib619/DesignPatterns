using AbstractFactory;
using AbstractFactory.Factories;

var factories = new Dictionary<string, UIFactory>
{
	["1"] = new WindowsUIFactory(),
	["2"] = new WebUIFactory(),
	["3"] = new MacUIFactory()
};

while (true)
{
	Console.WriteLine("1-Windows");
	Console.WriteLine("2-Web");
	Console.WriteLine("3-Mac");
	Console.Write("Choose Ui: ");

	var option = Console.ReadLine();

	if (factories.TryGetValue(option, out var factory))
	{
		var ui = new UserInterface(factory);
		ui.Start();
		ui.Shotdown();
	}
	else
	{
		Console.WriteLine("Invalid option!");
		Console.Write("press any key to continue...");
		Console.ReadKey();
		Console.Clear();
	}
}