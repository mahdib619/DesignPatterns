using Composite.Abstract;

namespace Composite.Concrete.Leaf;

internal class Mobile : IShopItem
{
	public string Model { get; set; }
	public decimal Total { get; }

	public Mobile(string model, decimal price)
	{
		Model = model;
		Total = price;
	}

	public void Ship(string address)
	{
		// shipping
	}
}
