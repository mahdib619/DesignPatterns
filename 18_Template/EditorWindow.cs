using System;
using Template;

namespace Template;

public class EditorWindow : Window
{
	protected override void OnClosing()
	{
		Console.WriteLine("save content");
	}

	protected override void OnClosed()
	{
		Console.WriteLine("open saved file");
	}
}
