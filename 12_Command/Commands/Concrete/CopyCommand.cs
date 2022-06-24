using Command.Commands.Abstract;

namespace Command.Commands.Concrete;

public class CopyCommand : BaseCommand
{
	public CopyCommand(Application app, Editor editor) : base(app, editor)
	{
	}

	public override void Execute()
	{
		App.ClipBoard = Editor.GetSelectedText();
	}
}
