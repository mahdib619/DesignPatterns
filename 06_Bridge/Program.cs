using Bridge.Bridge.Color.Concrete;
using Bridge.Bridge.Shape.Concrete;
using Bridge.NonBridge.Abstract;
using Bridge.NonBridge.ColorShape.Abstract;
using Bridge.NonBridge.ColorShape.Concrete.Circle;
using Bridge.NonBridge.ColorShape.Concrete.Rectangle;
using Bridge.NonBridge.ColorShape.Concrete.Square;

// Non bridged -- 3 Shapes * 3 Colors = 9 Classes
var shapes1 = new List<IShape1> { new BlueRectangle(), new GreenRectangle(), new RedRectangle(), new BlueSquare(), new GreenSquare(), new RedSquare(), new BlueCircle(), new GreenCircle(), new RedCircle() };

foreach (var shape in shapes1)
{
	shape.Draw();
}

Console.WriteLine("----------------------------------------");

// Bridged -- 3 Shapes + 3 Colors = 6 Classes
var blue = new BlueShapeColor();
var red = new RedShapeColor();
var green = new GreenShapeColor();

var shapes2 = new List<IShape2> { new Rectangle(blue), new Rectangle(green), new Rectangle(red), new Square(blue), new Square(green), new Square(red), new Circle(blue), new Circle(green), new Circle(red) };

foreach (var shape in shapes2)
{
	shape.Draw();
}
