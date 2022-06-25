using System;
using Mediator.Concrete;

var container = new ArticleContainer();

container.ArticleListBox.Selection = "Article1";
Console.WriteLine(container.SaveButton.IsEnabled);
Console.WriteLine(container.ArticleTextBox.Text);

container.ArticleTextBox.Text = "";
Console.WriteLine(container.SaveButton.IsEnabled);

container.SaveButton.Click();
Console.WriteLine(container.ArticleListBox.Selection);