namespace ChainOfResponsibility.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class LimitCorsAttribute : Attribute
{
	public string ValidOrigins { get; set; }
	public string ValidMethods { get; set; }
}
