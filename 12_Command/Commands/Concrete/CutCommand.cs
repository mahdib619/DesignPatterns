using Command.Commands.Abstract;

namespace Command.Commands.Concrete;

public class CutCommand : BaseCommand
{
	public CutCommand(Application app, Editor editor) : base(app, editor)
	{
	}

	public override void Execute()
	{
		App.ClipBoard = Editor.GetSelectedText();
		Editor.SetSelectedText("");
	}
}
