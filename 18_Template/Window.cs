using System;

namespace Template;

public abstract class Window
{
	public void Close()
	{
		OnClosing();
		Console.WriteLine("Windows closed");
		OnClosed();
	}

	protected abstract void OnClosing();
	protected abstract void OnClosed();
}
