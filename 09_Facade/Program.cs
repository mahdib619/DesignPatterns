using Facade.Client;
using Facade.Core.Concrete;

var client = new Client(new JsonToExcelFileConverter());
await client.SaveDataAsExcel();