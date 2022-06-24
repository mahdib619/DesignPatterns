// CoR pattern implementation is located in Handlers folder

using ChainOfResponsibility;
using ChainOfResponsibility.Models;

var req = new HttpRequest();

req.Uri = "FirstController";
ControllerManager.ExecuteRequest(req);

req.Uri = "SecondController";
req.Headers["Authentication"] = "Mahdi 123";
ControllerManager.ExecuteRequest(req);

req.Headers["Roles"] = "admin";
req.Uri = "ThirdController";
req.Headers["Origin"] = "localhost";
req.Method = "Get";
ControllerManager.ExecuteRequest(req);

Console.ReadLine();