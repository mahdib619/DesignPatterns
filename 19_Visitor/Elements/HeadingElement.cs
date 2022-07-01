using Visitor.Visitors;

namespace Visitor.Elements;

internal class HeadingElement : IHtmlElement
{
	public void Execute(IOperation operation)
	{
		operation.Apply(this);
	}
}
