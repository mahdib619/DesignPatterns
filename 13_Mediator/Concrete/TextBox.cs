using Mediator.Abstract;

namespace Mediator.Concrete;

public class TextBox : UiControl//Concrete Colleague
{
	private string _text;

	public string Text
	{
		get => _text;
		set
		{
			_text = value;
			Container.Notify(this);
		}
	}

	public TextBox(IControlContainer container) : base(container)
	{

	}
}
