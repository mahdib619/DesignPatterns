namespace State.States.Abstract;

public abstract class BasePlayerState : IPlayerState
{
	protected readonly AudioPlayer AudioPlayer;

	public BasePlayerState(AudioPlayer audioPlayer)
	{
		AudioPlayer = audioPlayer;
	}

	public abstract void ClickLock();
	public abstract void ClickNext(bool doubleClick);
	public abstract void ClickPrevious(bool doubleClick);
	public abstract void ClickPlay();
}
