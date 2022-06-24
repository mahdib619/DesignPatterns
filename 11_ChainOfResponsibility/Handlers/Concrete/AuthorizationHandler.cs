using ChainOfResponsibility.Handlers.Abstract;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Concrete;

public class AuthorizationHandler : BaseHttpHandler
{
	private readonly List<string> validRoles;

	public AuthorizationHandler(List<string> validRoles, IHttpHandler next = null) : base(next)
	{
		this.validRoles = validRoles;
	}

	protected override void DoHandle(HttpRequest request)
	{
		var roles = request.Headers.GetValueOrDefault("Roles", "").Split(",").Select(r => r.Trim());

		if (!validRoles.Intersect(roles).Any())
			throw new Exception("User doesn't have access to resource!");
	}
}
