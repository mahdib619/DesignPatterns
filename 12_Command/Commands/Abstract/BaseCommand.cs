namespace Command.Commands.Abstract;

public abstract class BaseCommand
{
	protected readonly Application App;
	protected readonly Editor Editor;

	public BaseCommand(Application app, Editor editor)
	{
		App = app;
		Editor = editor;
	}

	public abstract void Execute();
}
