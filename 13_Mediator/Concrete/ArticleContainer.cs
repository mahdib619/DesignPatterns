using Mediator.Abstract;
using System;

namespace Mediator.Concrete;

public class ArticleContainer : IControlContainer//Concrete Mediator
{
	public TextBox ArticleTextBox { get; }
	public Button SaveButton { get; }
	public ListBox ArticleListBox { get; }

	public ArticleContainer()
	{
		ArticleTextBox = new(this);
		SaveButton = new(this);
		ArticleListBox = new(this);
	}

	public void Notify(UiControl control, string @event = "")
	{
		if (control == ArticleTextBox)
		{
			ArticleTextBoxChanged();
		}
		else if (control == SaveButton)
		{
			if (@event == "click")
				SaveButtonClicked();
			else
				SaveButtonChanged();

		}
		else if (control == ArticleListBox)
		{
			ArticleListBoxChanged();
		}
	}

	private void ArticleTextBoxChanged()
	{
		if (string.IsNullOrWhiteSpace(ArticleTextBox.Text))
		{
			SaveButton.Disable();
		}
		else
		{
			SaveButton.Enable();
		}
	}

	private void SaveButtonChanged()
	{

	}

	private void SaveButtonClicked()
	{
		ArticleListBox.Selection = null;
		ArticleTextBox.Text = null;
	}

	private void ArticleListBoxChanged()
	{
		ArticleTextBox.Text = ArticleListBox.Selection;
	}
}
