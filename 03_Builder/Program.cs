using Builder.Builders;
using Builder.Director;

var webBuilder = new WebApplicationPageBuilder();
var windowsBuilder = new WindowsApplicationPageBuilder();

var myApp = webBuilder.DesignBody()
					.AddButton("Close")
					.Create();

Console.WriteLine(myApp);

myApp = windowsBuilder.DesignBody()
					.AddLabel("HelloWorld")
					.Create();
Console.WriteLine(myApp);


var webDirector = new ApplicationPageDirector(webBuilder);
var windowsDirector = new ApplicationPageDirector(windowsBuilder);

myApp = webDirector.CreateStudentForm();
Console.WriteLine(myApp);

myApp = windowsDirector.CreateStudentForm();
Console.WriteLine(myApp);

myApp = webDirector.CreateEmployeeForm();
Console.WriteLine(myApp);

myApp = windowsDirector.CreateEmployeeForm();
Console.WriteLine(myApp);