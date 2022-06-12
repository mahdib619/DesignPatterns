using Composite.Abstract;

namespace Composite.Concrete.Leaf;

internal class Book : IShopItem
{
	public string Name { get; set; }
	public decimal Total { get; }

	public Book(string name, decimal price)
	{
		Name = name;
		Total = price;
	}

	public void Ship(string address)
	{
		// shipping
	}
}
