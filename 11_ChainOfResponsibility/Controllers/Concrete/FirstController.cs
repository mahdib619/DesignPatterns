using ChainOfResponsibility.Controllers.Abstract;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Controllers.Concrete;

public class FirstController : ControllerBase
{
	public override void Action(HttpRequest req)
	{
		Console.WriteLine("Anonymous Access controller called");
	}
}
