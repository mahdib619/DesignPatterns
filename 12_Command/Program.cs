using Command;
using Command.Commands.Concrete;

var app = new Application();
var editor = new Editor();

editor.Text = "This is good";

var copyButton = new Button(new CopyCommand(app, editor));
var pasteButton = new Button(new PasteCommand(app, editor));
var cutButton = new Button(new CutCommand(app, editor));
var setSelectionButton = new Button(new SetSelectionCommand(app, editor));

setSelectionButton.Click();
copyButton.Click();

Console.WriteLine(app.ClipBoard);

cutButton.Click();
Console.WriteLine(editor.Text);