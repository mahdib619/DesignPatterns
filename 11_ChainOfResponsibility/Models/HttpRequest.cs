namespace ChainOfResponsibility.Models;

public class HttpRequest
{
	public string Uri { get; set; }
	public string Method { get; set; }
	public Dictionary<string, string> Headers { get; set; } = new();
}
