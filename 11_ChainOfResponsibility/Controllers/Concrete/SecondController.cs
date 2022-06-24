using ChainOfResponsibility.Attributes;
using ChainOfResponsibility.Controllers.Abstract;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Controllers.Concrete;

[Authorize]
public class SecondController : ControllerBase
{
	public override void Action(HttpRequest req)
	{
		Console.WriteLine("Controller with required username and password called");
	}
}
