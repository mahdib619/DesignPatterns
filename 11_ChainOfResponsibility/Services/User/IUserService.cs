namespace ChainOfResponsibility.Services.User;

public interface IUserService
{
	bool CanLogin(string userName, string password);
}