namespace State.States.Abstract;

public interface IPlayerState
{
	void ClickLock();
	void ClickNext(bool doubleClick);
	void ClickPrevious(bool doubleClick);
	void ClickPlay();
}
