namespace Composite.Abstract;

internal interface IShoppingCart : IPriceable
{
	void Add(IShopItem item);
	void Remove(IShopItem item);

	IReadOnlyCollection<IShopItem> Items { get; }
}
