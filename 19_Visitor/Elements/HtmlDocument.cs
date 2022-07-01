using System.Collections.Generic;
using Visitor.Visitors;


namespace Visitor.Elements;

internal class HtmlDocument
{
	private readonly List<IHtmlElement> _elements = new();

	public void AddElement(IHtmlElement element)
	{
		_elements.Add(element);
	}

	public void Execute(IOperation operation)
	{
		_elements.ForEach(e => e.Execute(operation));
	}
}
