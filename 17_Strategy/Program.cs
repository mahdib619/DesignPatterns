using Strategy;
using Strategy.Operations.Concrete;

var calculator = new Calculator();

while (true)
{
	try
	{
		Console.Write("Choose Operation:");
		var option = Console.ReadLine();

		calculator.Operator = option switch
		{
			"+" => new SumOperation(),
			"-" => new SubtractOperation(),
			"*" => new MultiplyOperation(),
			"/" => new DividivisionOperation(),
			_ => throw new InvalidOperationException("Invalid input!")
		};

		Console.Write("first number: ");
		var valid = int.TryParse(Console.ReadLine(), out var a);

		Console.Write("second number: ");
		var b = 0;
		valid = valid && int.TryParse(Console.ReadLine(), out b);

		if (!valid)
			throw new InvalidOperationException("Invalid input!");

		Console.Write("Result: ");
		Console.WriteLine(calculator.Calculate(a, b));

		Clear();
	}
	catch (Exception e)
	{
		Console.WriteLine(e.Message);
		Clear();
	}
}

void Clear()
{
	Console.Write("Press any key to continue...");
	Console.ReadKey();
	Console.Clear();
}