using Decorator.Abstract;
using Decorator.Concrete.Decorators.Base;

namespace Decorator.Concrete.Decorators;

public class EncryptedFileWriter : BaseFileWriterDecorator
{
	public EncryptedFileWriter(IFileWriter @base) : base(@base)
	{
	}

	protected override void BeforeWrite(string path, string txt)
	{
		Console.WriteLine($"Encrypt {txt} for {path}");
	}
}
