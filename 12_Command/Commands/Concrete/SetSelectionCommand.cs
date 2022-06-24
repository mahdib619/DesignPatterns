using Command.Commands.Abstract;

namespace Command.Commands.Concrete;

public class SetSelectionCommand : BaseCommand
{
	public SetSelectionCommand(Application app, Editor editor) : base(app, editor)
	{
	}

	public override void Execute()
	{
		Console.Write("Start:");
		int.TryParse(Console.ReadLine(), out var start);

		Console.Write("End:");
		int.TryParse(Console.ReadLine(), out var end);

		Editor.SetSelection(start, end);
	}
}
