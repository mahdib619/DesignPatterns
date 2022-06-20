using Decorator.Abstract;

namespace Decorator.Concrete.Decorators.Base;

public abstract class BaseFileWriterDecorator : IFileWriter
{
	private readonly IFileWriter _base;

	protected BaseFileWriterDecorator(IFileWriter @base)
	{
		_base = @base;
	}
	public void Write(string path, string txt)
	{
		BeforeWrite(path, txt);
		_base.Write(path, txt);
	}

	protected abstract void BeforeWrite(string path, string txt);
}
