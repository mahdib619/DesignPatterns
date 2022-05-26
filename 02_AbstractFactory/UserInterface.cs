using AbstractFactory.Factories;

namespace AbstractFactory;

public class UserInterface
{
    private readonly UIFactory _factory;

    public UserInterface(UIFactory factory)
    {
        _factory = factory;
    }

    public void Start()
    {
        Console.WriteLine("Starting app...");
		Console.WriteLine();

        _factory.GetLabel("Name", ConsoleColor.Red).Render();
        _factory.GetTextBox("Mahdi").Render();

		Console.WriteLine();

        _factory.GetLabel("Age", ConsoleColor.Green).Render();
        _factory.GetTextBox("21").Render();

		Console.WriteLine();

		_factory.GetButton("Submit").Render();

        Console.Write("Press any key to continue.");
		Console.ReadKey();
	}

	public void Shotdown()
    {
        Console.Clear();
    }
}