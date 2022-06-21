namespace Proxy.Main.Main;

public class CourseVideo
{
	public string Title { get; set; }

	public CourseVideo(string title)
	{
		Title = title;
	}

	public virtual void Play()
	{
		Console.WriteLine($"Play video: {Title}");
	}
}
