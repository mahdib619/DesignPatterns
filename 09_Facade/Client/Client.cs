using Facade.Core.Abstract;
using Newtonsoft.Json;

namespace Facade.Client;
public class Client
{
	private readonly IJsonToExcelFileConverter _converter;

	public Client(IJsonToExcelFileConverter converter)
	{
		_converter = converter;
	}

	private void GenerateData(int count)
	{
		var item = new { FirstName = "Mahdi", LastName = "Akbari", Age = 15 };
		var data = Enumerable.Repeat(item, count);
		File.WriteAllText(Path.Combine(Environment.CurrentDirectory,"good.json"), JsonConvert.SerializeObject(data));
	}

	public async Task SaveDataAsExcel()
	{
		GenerateData(50);

		await _converter.Convert(Path.Combine(Environment.CurrentDirectory, "good.json"));//simply calls the facade
	}
}
