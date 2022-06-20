using Decorator.Abstract;

namespace Decorator.Concrete.Main;
public class FileWriter : IFileWriter
{
	public void Write(string path, string txt)
	{
		Console.WriteLine($"Write {txt} to {path}.");
	}
}
