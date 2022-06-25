using Mediator.Abstract;

namespace Mediator.Concrete;

public class Button : UiControl//Concrete Colleague
{
	private bool _enabled;
	public bool IsEnabled => _enabled;

	public Button(IControlContainer container) : base(container)
	{
	}

	public void Enable()
	{
		_enabled = true;
		Container.Notify(this);
	}

	public void Disable()
	{
		_enabled = false;
		Container.Notify(this);
	}

	public void Click()
	{
		Container.Notify(this, "click");
	}
}
