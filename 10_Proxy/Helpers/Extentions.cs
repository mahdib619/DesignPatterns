namespace Proxy.Helpers;

public static class Extentions
{
	public static bool IsTypeOf<T>(this object obj)
	{
		return obj.GetType().IsAssignableTo(typeof(T));
	}
}
