using Mediator.Abstract;

namespace Mediator.Concrete;

public class ListBox : UiControl//Concrete Colleague
{
	private string _selection;

	public string Selection
	{
		get => _selection;
		set
		{
			_selection = value;
			Container.Notify(this);
		}
	}

	public ListBox(IControlContainer container) : base(container)
	{
	}
}
