using Adapter.Lib;
using Adapter.MyConsoleChart;
using System.Reflection;
using System.Text;

namespace Adapter.Adapter;

public class LibBarCharPrinterAdapter : IConsoleChartPrinter
{
	private readonly LibBarChartPrinter chartPrinter = new();

	public void PrintBarChart(object data)
	{
		chartPrinter.Print(ConvertData(data));
	}

	private string ConvertData(object data)
	{
		var rawColumns = data.GetType()
				.GetProperties()
				.Where(p => p.GetCustomAttribute<ChartColumnAttribute>() is not null && int.TryParse(p.GetValue(data)?.ToString(), out _))
				.Select(p => (p.GetCustomAttribute<ChartColumnAttribute>().Name, Value: Convert.ToInt32(p.GetValue(data))))
				.ToList();

		var builder = new StringBuilder("{");
		foreach (var (Name, Value) in rawColumns)
		{
			builder.Append($"\"column_{Name}\": {Value}");
		}
		builder.Append('}');

		return builder.ToString();
	}
}
