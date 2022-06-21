using Proxy.Main.Main;
using Proxy.Main.Proxy;

namespace Proxy.Serivces.Video;

public class VideoService : IVideoService
{
	private readonly Dictionary<int, CourseVideo> _videos = new();

	public VideoService(IUserService userService)
	{
		_videos.Add(1, new CourseVideo("Intro to c#"));
		_videos.Add(2, new CourseVideo("Intro to python"));
		_videos.Add(3, new PermiumCourseVideo(userService, "Advanced c#"));
		_videos.Add(4, new PermiumCourseVideo(userService, "Advanced python"));
	}

	public IEnumerable<KeyValuePair<int, CourseVideo>> GetAll() => _videos.ToList();

	public CourseVideo GetVideo(int id) => _videos.GetValueOrDefault(id);
}
