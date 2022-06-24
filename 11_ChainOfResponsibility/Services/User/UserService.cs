namespace ChainOfResponsibility.Services.User;

public class UserService : IUserService
{
	public bool CanLogin(string userName, string password)
	{
		return userName.Contains("Mahdi", StringComparison.OrdinalIgnoreCase) && password == "123";
	}
}
