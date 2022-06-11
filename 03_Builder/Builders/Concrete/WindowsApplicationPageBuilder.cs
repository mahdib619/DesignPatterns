using Builder.Product;
using Builder.Builders.Abstract;

namespace Builder.Builders.Concrete;

public class WindowsApplicationPageBuilder : IApplicationPageBuilder
{
	private ApplicationPage _product;
	private List<string> _currentChangingPart;

	public WindowsApplicationPageBuilder()
	{
		_product = new();
		_currentChangingPart = _product.Header;
	}

	public IApplicationPageBuilder AddButton(string text)
	{
		_currentChangingPart.Add($"*Button* {text} *Button*");
		return this;
	}

	public IApplicationPageBuilder AddLabel(string text)
	{
		_currentChangingPart.Add($"*Label* {text} *Label*");
		return this;
	}

	public IApplicationPageBuilder AddLine(int width)
	{
		_currentChangingPart.Add(string.Join("", Enumerable.Repeat("-", width)));
		return this;
	}

	public IApplicationPageBuilder AddTextbox()
	{
		_currentChangingPart.Add($"*TextBox* *TextBox*");
		return this;
	}

	public ApplicationPage Create()
	{
		var product = _product;
		Reset();
		return product;
	}

	public IApplicationPageBuilder DesignBody()
	{
		_currentChangingPart = _product.Body;
		return this;
	}

	public IApplicationPageBuilder DesignFooter()
	{
		_currentChangingPart = _product.Footer;
		return this;
	}

	public IApplicationPageBuilder DesignHeader()
	{
		_currentChangingPart = _product.Header;
		return this;
	}

	private void Reset()
	{
		_product = new();
		_currentChangingPart = _product.Header;
	}
}
