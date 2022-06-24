using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Abstract;

public interface IHttpHandler
{
	void Handle(HttpRequest request);
}
