namespace Command;

public class Editor //receiver
{
	private (int start, int end) _selection;
	public string Text { get; set; }

	public void SetSelection(int start, int end) => _selection = (start, end);
	public string GetSelectedText() => Text[_selection.start.._selection.end];
	public void SetSelectedText(string text)
	{
		ReadOnlySpan<char> rs = Text;

		var before = rs[.._selection.start];
		var after = rs[(_selection.end + 1)..];

		Text = $"{before}{text}{after}";
		_selection = (_selection.start, _selection.start + text.Length);
	}
}