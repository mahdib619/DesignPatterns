using State.States.Abstract;
using State.States.Concrete;

namespace State;

public class AudioPlayer
{
	public IPlayerState State { get; set; }

	public AudioPlayer()
	{
		State = new LockState(this);
	}

	public void FastForward(int seconds)
	{
		Console.WriteLine($"FastForward music {seconds} seconds.");
	}

	public void Rewind(int seconds)
	{
		Console.WriteLine($"Rewind music {seconds} seconds.");
	}

	public void NextMusic()
	{
		Console.WriteLine("Next music");
	}

	public void PreviousMusic()
	{
		Console.WriteLine("Previous music");
	}

	public void ClickLock() => State.ClickLock();
	public void ClickNext(bool doubleClick) => State.ClickNext(doubleClick);
	public void ClickPrevious(bool doubleClick) => State.ClickPrevious(doubleClick);
	public void ClickPlay() => State.ClickPlay();
}
