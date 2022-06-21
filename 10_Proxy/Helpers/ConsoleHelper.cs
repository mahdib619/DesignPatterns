namespace Proxy.Helpers;

public static class ConsoleHelper
{
	public static void WriteAndWaitForAnyKey(string value)
	{
		Console.Write(value);
		Console.Write("Press any key to continue.");
		Console.ReadKey();
	}
}
