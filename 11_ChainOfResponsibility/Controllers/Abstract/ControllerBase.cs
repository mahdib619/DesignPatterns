using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Controllers.Abstract;

public abstract class ControllerBase
{
	public abstract void Action(HttpRequest request);
}
