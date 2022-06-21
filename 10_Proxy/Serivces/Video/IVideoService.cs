using Proxy.Main.Main;

namespace Proxy.Serivces.Video;

public interface IVideoService
{
	IEnumerable<KeyValuePair<int, CourseVideo>> GetAll();
	CourseVideo GetVideo(int id);
}
