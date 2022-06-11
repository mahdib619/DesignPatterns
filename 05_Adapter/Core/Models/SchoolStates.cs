using Adapter.MyConsoleChart;

namespace Adapter.Core.Models;

public class SchoolStates
{
	[ChartColumn("StudentCount")]
	public int StudentsCount { get; set; }
}
