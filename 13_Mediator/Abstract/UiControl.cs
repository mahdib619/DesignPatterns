namespace Mediator.Abstract;

public abstract class UiControl//Collegue
{
	protected readonly IControlContainer Container;

	protected UiControl(IControlContainer container)
	{
		Container = container;
	}
}
