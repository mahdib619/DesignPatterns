using Command.Commands.Abstract;

namespace Command;

public class Button //sender
{
	private readonly BaseCommand _onclick;

	public Button(BaseCommand onclick)
	{
		_onclick = onclick;
	}

	public void Click() => _onclick.Execute();
}
