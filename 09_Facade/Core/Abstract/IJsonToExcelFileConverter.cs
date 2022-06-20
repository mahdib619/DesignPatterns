namespace Facade.Core.Abstract;

public interface IJsonToExcelFileConverter
{
	public Task Convert(string jsonFilePath);
}