namespace Composite.Abstract;

internal interface IShopItem : IPriceable
{
	void Ship(string address);
}
