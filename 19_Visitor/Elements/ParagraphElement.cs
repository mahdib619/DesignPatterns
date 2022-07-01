using Visitor.Visitors;

namespace Visitor.Elements;

internal class ParagraphElement : IHtmlElement
{
	public void Execute(IOperation operation)
	{
		operation.Apply(this);
	}
}
