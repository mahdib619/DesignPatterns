using System;
using Visitor.Elements;

namespace Visitor.Visitors
{
	internal class PlainTextOperation:IOperation
    {
        public void Apply(HeadingElement heading)
        {
            Console.WriteLine("Plain text heading");
        }

        public void Apply(ParagraphElement paragraph)
        {
            Console.WriteLine("Plain text paragraph");
        }
    }
}
