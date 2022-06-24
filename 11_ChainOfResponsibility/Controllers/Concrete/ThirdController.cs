using ChainOfResponsibility.Attributes;
using ChainOfResponsibility.Controllers.Abstract;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Controllers.Concrete;

[Authorize(Roles = "admin")]
[LimitCors(ValidMethods = "Get, Post", ValidOrigins = "localhost")]
public class ThirdController : ControllerBase
{
	public override void Action(HttpRequest req)
	{
		Console.WriteLine("Controller with required username and password and roles and limited cors called");
	}
}
