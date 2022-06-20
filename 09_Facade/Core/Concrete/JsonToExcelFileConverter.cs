using System.Reflection;
using Facade.Core.Abstract;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.XSSF.UserModel;

namespace Facade.Core.Concrete;

public class JsonToExcelFileConverter : IJsonToExcelFileConverter
{
	public async Task Convert(string jsonFilePath)// Facade
	{
		//All the complexity encapsulated here and the client code is not coupled to this subsystem of objects
		var json = await ReadJsonFile(jsonFilePath);
		var obj = GetJsonObject(json);
		var excel = GetExcelFromObject(obj.ToList());
		var outPath = GetOutputPath(jsonFilePath);
		SaveExcel(excel, outPath);
	}

	private async Task<string> ReadJsonFile(string path)
	{
		return await File.ReadAllTextAsync(path);
	}

	private IEnumerable<JObject> GetJsonObject(string json)
	{
		return JsonConvert.DeserializeObject<IEnumerable<JObject>>(json);
	}

	private XSSFWorkbook GetExcelFromObject(List<JObject> items)
	{
		var workbook = new XSSFWorkbook();
		var sheet = workbook.CreateSheet();

		for (var i = 0; i < items.Count; i++)
		{
			var item = items[i];
			var row = sheet.CreateRow(i);

			var colI = 0;
			foreach (var child in item.Children())
			{
				var cell = row.CreateCell(colI++);
				var value = child.First.Value<dynamic>().Value;
				try
				{
					cell.SetCellValue(value);
				}
				catch (RuntimeBinderException)
				{
					cell.SetCellValue(value.ToString());
				}
			}
		}

		return workbook;
	}

	private string GetOutputPath(string sourcPath)
	{
		var sourceFileInfo = new FileInfo(sourcPath);
		return sourcPath.Replace(sourceFileInfo.Extension, ".xlsx");
	}

	private void SaveExcel(XSSFWorkbook workbook, string fileName)
	{
		using var fileStream = new FileStream(fileName, FileMode.Create);
		workbook.Write(fileStream);
	}
}