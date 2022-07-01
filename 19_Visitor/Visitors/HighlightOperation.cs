using System;
using Visitor.Elements;

namespace Visitor.Visitors;

internal class HighlightOperation : IOperation
{
	public void Apply(HeadingElement heading)
	{
		Console.WriteLine("Highlight heading");
	}

	public void Apply(ParagraphElement paragraph)
	{
		Console.WriteLine("Highlight paragraph");
	}
}
