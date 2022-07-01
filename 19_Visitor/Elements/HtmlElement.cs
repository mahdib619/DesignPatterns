using Visitor.Visitors;

namespace Visitor.Elements;

internal interface IHtmlElement
{
	void Execute(IOperation operation);
}
