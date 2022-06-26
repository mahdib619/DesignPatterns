using State.States.Abstract;

namespace State.States.Concrete;

public class PlayingState : BasePlayerState
{
	public PlayingState(AudioPlayer audioPlayer) : base(audioPlayer)
	{
	}

	public override void ClickLock()
	{
		AudioPlayer.State = new LockState(AudioPlayer);
		Console.WriteLine("Lock player");
	}

	public override void ClickNext(bool doubleClick)
	{
		if (doubleClick)
			AudioPlayer.NextMusic();
		else
			AudioPlayer.FastForward(5);
	}

	public override void ClickPrevious(bool doubleClick)
	{
		if (doubleClick)
			AudioPlayer.PreviousMusic();
		else
			AudioPlayer.Rewind(5);
	}

	public override void ClickPlay()
	{
		AudioPlayer.State = new ReadyState(AudioPlayer);
		Console.WriteLine("Stop playing");
	}
}
