using Proxy.Helpers;
using Proxy.Main.Proxy;

namespace Proxy.Menus;

public class VideoMenu : BaseMenu
{
	private readonly IVideoService _videoService;

	public VideoMenu(IVideoService videoService)
	{
		_videoService = videoService;
	}

	protected override void DoShow()
	{
		var videos = _videoService.GetAll().ToList();
		foreach (var kv in videos)
		{
			var video = kv.Value;

			var dc = Console.ForegroundColor;
			if (video.IsTypeOf<PermiumCourseVideo>())
				Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine($"{kv.Key}-{video.Title}");
			Console.ForegroundColor = dc;
		}

		Console.Write("Option:");
		var idStr = Console.ReadLine();

		if (!int.TryParse(idStr, out var id))
		{
			Console.Write("Invalid Input! ");
			return;
		}

		var selctedVideo = _videoService.GetVideo(id);
		if (selctedVideo is null)
			Console.Write("Video not found! ");
		else
		{
			try
			{
				selctedVideo.Play();
			}
			catch (UnauthorizedAccessException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
