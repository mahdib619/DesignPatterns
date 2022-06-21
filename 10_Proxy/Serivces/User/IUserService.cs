namespace Proxy.Serivces.User;

public interface IUserService
{
	bool Login(string userName, string password);
	void Logout();
	string GetCurrentUser();
}
