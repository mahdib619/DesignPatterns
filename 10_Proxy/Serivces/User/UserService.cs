namespace Proxy.Serivces.User;

public class UserService : IUserService
{
	private string _currentUser;

	public bool Login(string userName, string password)
	{
		if (userName != "mahdi" || password != "123")
			return false;

		_currentUser = userName;
		return true;
	}

	public void Logout() => _currentUser = null;

	public string GetCurrentUser() => _currentUser;
}
