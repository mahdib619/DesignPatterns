using State.States.Abstract;

namespace State.States.Concrete;

public class LockState : BasePlayerState
{
	public LockState(AudioPlayer audioPlayer) : base(audioPlayer)
	{
	}

	public override void ClickLock()
	{
		AudioPlayer.State = new ReadyState(AudioPlayer);
		Console.WriteLine("Unlock player");
	}

	public override void ClickNext(bool doubleClick)
	{
		Console.WriteLine("Do nothing");
	}

	public override void ClickPrevious(bool doubleClick)
	{
		Console.WriteLine("Do nothing");
	}

	public override void ClickPlay()
	{
		Console.WriteLine("Do nothing");
	}
}
