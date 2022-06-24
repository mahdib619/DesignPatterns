namespace ChainOfResponsibility.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class AuthorizeAttribute : Attribute
{
	public string Roles { get; set; }
}
