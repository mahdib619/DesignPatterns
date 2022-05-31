using System.Text;

namespace Builder.Product;

public class ApplicationPage
{
	public List<string> Header { get; private set; } = new();
	public List<string> Body { get; private set; } = new();
	public List<string> Footer { get; private set; } = new();

	public override string ToString()
	{
		var output = new StringBuilder();

		if (Header.Any())
		{
			output.AppendLine(string.Join(Environment.NewLine, Header));
			output.AppendLine("-----------------------------------------");
		}

		if (Body.Any())
		{
			output.AppendLine(string.Join(Environment.NewLine, Body));
			output.AppendLine("-----------------------------------------");
		}

		if(Footer.Any())
			output.AppendLine(string.Join(Environment.NewLine, Footer));

		return output.ToString();
	}
}
