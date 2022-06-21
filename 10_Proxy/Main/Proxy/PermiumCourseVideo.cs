using Proxy.Main.Main;

namespace Proxy.Main.Proxy;

public class PermiumCourseVideo : CourseVideo
{
	private readonly IUserService _userService;

	public PermiumCourseVideo(IUserService userService, string title) : base(title)
	{
		_userService = userService;
	}

	public override void Play()
	{
		var user = _userService.GetCurrentUser();
		if (user is null)
			throw new UnauthorizedAccessException("This is a permium course, please login.");

		base.Play();
	}
}
