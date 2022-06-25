namespace Mediator.Abstract;

public interface IControlContainer//Mediator
{
	void Notify(UiControl control, string @event = "");
}
