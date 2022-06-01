namespace Prototype;

public class Rectangle : Shape
{
	public Rectangle(){}
	public Rectangle(Rectangle source) : base(source)
	{
		Width = source.Width;
		Height = source.Height;
	}

	public int Width { get; set; }
	public int Height { get; set; }

	public override Shape Clone() => new Rectangle(this);

	public override string ToString() => $"{Color} rectangle w:{Width} h:{Height} at ({X},{Y})";
}
