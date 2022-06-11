using Builder.Product;
using Builder.Builders.Abstract;

namespace Builder.Builders.Concrete;

public class WebApplicationPageBuilder : IApplicationPageBuilder
{
	private ApplicationPage _product;
	private List<string> _currentChangingPart;

	public WebApplicationPageBuilder()
	{
		_product = new();
		_currentChangingPart = _product.Header;
	}

	public IApplicationPageBuilder AddButton(string text)
	{
		_currentChangingPart.Add($"<button>{text}</button>");
		return this;
	}

	public IApplicationPageBuilder AddLabel(string text)
	{
		_currentChangingPart.Add($"<label>{text}</label>");
		return this;
	}

	public IApplicationPageBuilder AddLine(int width)
	{
		_currentChangingPart.Add($"<hr width='{width}'/>");
		return this;
	}

	public IApplicationPageBuilder AddTextbox()
	{
		_currentChangingPart.Add($"<input type='text'/>");
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
