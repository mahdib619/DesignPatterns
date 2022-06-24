using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Abstract;

public abstract class BaseHttpHandler : IHttpHandler
{
	private readonly IHttpHandler _next;

	public BaseHttpHandler(IHttpHandler next = null)
	{
		_next = next;
	}

	public void Handle(HttpRequest request)
	{
		DoHandle(request);

		if (_next is not null)
			_next.Handle(request);
	}

	protected abstract void DoHandle(HttpRequest request);
}
