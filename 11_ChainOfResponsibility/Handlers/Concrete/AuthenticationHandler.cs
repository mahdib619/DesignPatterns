using ChainOfResponsibility.Handlers.Abstract;
using ChainOfResponsibility.Models;
using ChainOfResponsibility.Services.User;

namespace ChainOfResponsibility.Handlers.Concrete;

public class AuthenticationHandler : BaseHttpHandler
{
	private readonly IUserService _userService;

	public AuthenticationHandler(IUserService userService, IHttpHandler next = null) : base(next)
	{
		_userService = userService;
	}

	protected override void DoHandle(HttpRequest request)
	{
		var auth = request.Headers.GetValueOrDefault("Authentication", "").Split(" ");

		var username = auth[0];
		var password = auth.Skip(1).FirstOrDefault();

		if (!_userService.CanLogin(username, password))
			throw new Exception("Invalid username or password!");
	}
}
