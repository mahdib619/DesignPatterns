using Command.Commands.Abstract;

namespace Command.Commands.Concrete;

public class PasteCommand : BaseCommand
{
	public PasteCommand(Application app, Editor editor) : base(app, editor)
	{
	}

	public override void Execute()
	{
		Editor.SetSelectedText(App.ClipBoard);
	}
}
