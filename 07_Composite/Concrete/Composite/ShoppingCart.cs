using Composite.Abstract;

namespace Composite.Concrete.Composite;

internal class ShoppingCart : IShoppingCart
{
	private readonly LinkedList<IShopItem> _items = new();

	public IReadOnlyCollection<IShopItem> Items => _items;
	public decimal Total => _items.Sum(i => i.Total);

	public void Add(IShopItem item)
	{
		_items.AddLast(item);
	}

	public void Remove(IShopItem item)
	{
		_items.Remove(item);
	}
}
