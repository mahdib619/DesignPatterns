using Strategy.Operations.Abstract;

namespace Strategy.Operations.Concrete;

public class MultiplyOperation : IMathOperation
{
	public int Operate(int a, int b)
	{
		return a * b;
	}
}
