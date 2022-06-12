using Composite.Concrete.Composite;
using Composite.Concrete.Leaf;

var cart = new ShoppingCart();

var samsung = new Mobile("Samsung", 20000);
var iphone = new Mobile("IPhone", 40000);
var mobilesBox = new Box(samsung, iphone);
cart.Add(mobilesBox);

var math = new Book("Math", 100);
var heWasStupid = new Book("He was stupid", 350);
var booksBox = new Box(heWasStupid, math);
cart.Add(booksBox);

Console.WriteLine(cart.Total);