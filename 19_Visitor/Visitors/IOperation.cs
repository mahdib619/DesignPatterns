using Visitor.Elements;

namespace Visitor.Visitors;

internal interface IOperation
{
	void Apply(HeadingElement heading);
	void Apply(ParagraphElement paragraph);
}
