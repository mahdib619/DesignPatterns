using Builder.Product;
using Builder.Builders.Abstract;

namespace Builder.Builders.Abstract;

public interface IApplicationPageBuilder
{
	IApplicationPageBuilder DesignHeader();
	IApplicationPageBuilder DesignBody();
	IApplicationPageBuilder DesignFooter();
	IApplicationPageBuilder AddButton(string text);
	IApplicationPageBuilder AddLabel(string text);
	IApplicationPageBuilder AddTextbox();
	IApplicationPageBuilder AddLine(int width);
	ApplicationPage Create();
}
