using Builder.Product;

namespace Builder.Builders;

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
