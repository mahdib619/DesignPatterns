using Composite.Abstract;

namespace Composite.Concrete.Composite;

internal class Box : IShopItem
{
	private readonly IShopItem[] _items;
	private const decimal BOXING_COST = 4;

	public decimal Total => _items.Sum(i => i.Total) + BOXING_COST;

	public Box(params IShopItem[] items)
	{
		_items = items;
	}

	public void Ship(string address)
	{
		foreach (var item in _items)
			item.Ship(address);
	}
}
