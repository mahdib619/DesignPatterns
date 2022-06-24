using ChainOfResponsibility.Attributes;
using ChainOfResponsibility.Controllers.Abstract;
using ChainOfResponsibility.Handlers.Abstract;
using ChainOfResponsibility.Handlers.Concrete;
using ChainOfResponsibility.Models;
using ChainOfResponsibility.Services.User;
using System.Reflection;

namespace ChainOfResponsibility;

public static class ControllerManager
{
	private static readonly Dictionary<string, (ControllerBase controller, IHttpHandler handler)> controllersAndHandlers = new();

	static ControllerManager()
	{
		var userService = new UserService();
		var baseControllerType = typeof(ControllerBase);
		var controllerTypes = Assembly.GetCallingAssembly().GetTypes().Where(t => t.IsAssignableTo(baseControllerType) && !t.IsAbstract);

		foreach (var c in controllerTypes)
		{
			IHttpHandler handler = null;

			var authAttr = c.GetCustomAttribute<AuthorizeAttribute>();
			if (authAttr is not null)
			{
				if (authAttr.Roles is not null)
				{
					var roles = authAttr.Roles.Split(",").Select(v => v.Trim()).ToList();
					handler = new AuthorizationHandler(roles, handler);
				}

				handler = new AuthenticationHandler(userService, handler);
			}

			var corsAttr = c.GetCustomAttribute<LimitCorsAttribute>();
			if (corsAttr is not null)
			{
				var origins = corsAttr.ValidOrigins?.Split(",").Select(v => v.Trim()).ToList();
				var methods = corsAttr.ValidMethods?.Split(",").Select(v => v.Trim()).ToList();
				handler = new CorsHandler(origins, methods, handler);
			}

			controllersAndHandlers[c.Name.ToLower()] = ((ControllerBase)Activator.CreateInstance(c), new EmptyHandler(handler));
		}
	}

	public static void ExecuteRequest(HttpRequest request)
	{
		if (!controllersAndHandlers.TryGetValue(request.Uri.ToLower(), out var cAndH))
			throw new Exception("Not found!");

		try
		{
			cAndH.handler.Handle(request);
			cAndH.controller.Action(request);
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
