namespace Adapter.MyConsoleChart;

[AttributeUsage(AttributeTargets.Property)]
public class ChartColumnAttribute : Attribute
{
	public string Name { get; set; }

	public ChartColumnAttribute(string name) => Name = name;
}
