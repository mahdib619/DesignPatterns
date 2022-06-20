using Prototype.Abstract;

namespace Prototype.Concrete;

public class Circle : Shape
{
	public Circle(){}
	public Circle(Circle source) : base(source)
	{
		Radius = source.Radius;
	}

	public int Radius { get; set; }

	public override Shape Clone() => new Circle(this);

	public override string ToString() => $"{Color} circle r:{Radius} at ({X},{Y})";
}
