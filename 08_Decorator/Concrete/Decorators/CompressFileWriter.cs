using Decorator.Abstract;
using Decorator.Concrete.Decorators.Base;

namespace Decorator.Concrete.Decorators;
public class CompressFileWriter : BaseFileWriterDecorator
{
	public CompressFileWriter(IFileWriter @base) : base(@base)
	{
	}

	protected override void BeforeWrite(string path, string txt)
	{
		Console.WriteLine($"Compress {txt} ...");
	}
}
