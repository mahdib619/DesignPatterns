using ChainOfResponsibility.Handlers.Abstract;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Concrete;

public class CorsHandler : BaseHttpHandler
{
	private readonly List<string> _validOrigins;
	private readonly List<string> _validMethods;

	public CorsHandler(List<string> validOrigins = null, List<string> validMethods = null, IHttpHandler next = null) : base(next)
	{
		_validOrigins = validOrigins;
		_validMethods = validMethods;
	}

	protected override void DoHandle(HttpRequest request)
	{
		var origin = request.Headers.GetValueOrDefault("Origin", "");
		if (_validOrigins is not null && !_validOrigins.Contains(origin))
			throw new Exception("Invalid origin");

		if (_validMethods is not null && !_validMethods.Contains(request.Method))
			throw new Exception("Invalid method");
	}
}
