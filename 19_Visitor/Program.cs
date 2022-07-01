using System;
using Visitor.Elements;
using Visitor.Visitors;

var document = new HtmlDocument();
document.AddElement(new HeadingElement());
document.AddElement(new ParagraphElement());

document.Execute(new HighlightOperation());
Console.WriteLine("---------------------");
document.Execute(new PlainTextOperation());