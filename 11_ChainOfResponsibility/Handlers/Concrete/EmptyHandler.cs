using ChainOfResponsibility.Handlers.Abstract;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Concrete;

public class EmptyHandler : BaseHttpHandler
{
	public EmptyHandler(IHttpHandler next = null) : base(next)
	{
	}

	protected override void DoHandle(HttpRequest request)
	{
		
	}
}
