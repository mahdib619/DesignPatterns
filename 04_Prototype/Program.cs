using Prototype.Abstract;
using Prototype.Concrete;

var sourceShapes = new List<Shape>();

sourceShapes.Add(new Rectangle { Color = "Green", X = 100, Y = 150, Height = 254, Width = 785 });
sourceShapes.Add(new Rectangle { Color = "Blue", X = 42, Y = 81, Height = 124, Width = 36 });
sourceShapes.Add(new Rectangle { Color = "Red", X = 87, Y = 24, Height = 101, Width = 89 });

sourceShapes.Add(new Circle { Color = "Green", X = 100, Y = 150, Radius = 254 });
sourceShapes.Add(new Circle { Color = "Blue", X = 42, Y = 81, Radius = 124 });
sourceShapes.Add(new Circle { Color = "Red", X = 87, Y = 24, Radius = 101 });

var clonedShapes = sourceShapes.Select(s => { var cs = s.Clone(); cs.X -= 100; return cs; }).ToList();

sourceShapes.ForEach(s => Console.WriteLine(s));
Console.WriteLine("---------------------------------------");
clonedShapes.ForEach(s => Console.WriteLine(s));