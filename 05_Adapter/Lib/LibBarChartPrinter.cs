using Newtonsoft.Json;

namespace Adapter.Lib;

public class LibBarChartPrinter
{
	private const char ROW_CHAR = '#';
	private const char EMPTY_ROW_CHAR = ' ';
	private const char NAME_FOOTER_SEPERATOR_CHAR = '-';
	private const string COL_SEPRATOR = "   ";

	public void Print(string json)
	{
		var columns = JsonConvert.DeserializeObject<Dictionary<string, string>>(json)
						.Where(kv => kv.Key.StartsWith("column_", StringComparison.OrdinalIgnoreCase) && int.TryParse(kv.Value, out _))
						.Select(kv => (Name: kv.Key[7..], Value: Convert.ToInt32(kv.Value)))
						.ToList();

		var maxValue = columns.Max(c => c.Value);
		var lRow = columns.Max(c => c.Name.Length);

		var rowString = ROW_CHAR.ToString().PadRight(lRow, ROW_CHAR);
		var emptyRowString = EMPTY_ROW_CHAR.ToString().PadRight(lRow, EMPTY_ROW_CHAR);

		for (var i = maxValue; i > 0; i--)
		{
			Console.Write(i.ToString().PadLeft(maxValue.ToString().Length) + "| ");
			var row = new LinkedList<string>();
			foreach (var (_, Value) in columns)
			{
				row.AddLast(Value >= i ? rowString : emptyRowString);
			}
			Console.WriteLine(string.Join(COL_SEPRATOR, row));
		}

		var names = string.Join("", columns.Select(c => c.Name.PadRight(lRow + COL_SEPRATOR.Length)));

		var sepRight = "".PadRight(names.Length, NAME_FOOTER_SEPERATOR_CHAR);
		var sepLeft = "".PadRight(maxValue.ToString().Length, NAME_FOOTER_SEPERATOR_CHAR);
		Console.WriteLine($"{sepLeft}|{sepRight}");

		var namesEmptyArea = sepLeft.Replace(NAME_FOOTER_SEPERATOR_CHAR, ' ');
		Console.WriteLine($"{namesEmptyArea}| {names}");
	}
}
