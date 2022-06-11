using Adapter.Core.Models;
using Adapter.MyConsoleChart;

namespace Adapter.Core.Services;

public interface ISchoolService
{
	void SignupStudent(string name, string grade);
	void PrintStates();
}

public class SchoolService : ISchoolService
{
	private readonly Dictionary<string, string> _students = new();
	private readonly IConsoleChartPrinter chartPrinter;
	private readonly SchoolStates _states = new();

	public SchoolService(IConsoleChartPrinter chartPrinter)
	{
		this.chartPrinter = chartPrinter;
	}

	public void SignupStudent(string name, string grade)
	{
		_students.TryAdd(grade, name);
		_states.StudentsCount++;
	}

	public void PrintStates()
	{
		chartPrinter.PrintBarChart(_states);
	}
}