using Strategy.Operations.Abstract;

namespace Strategy.Operations.Concrete;

public class DividivisionOperation : IMathOperation
{
	public int Operate(int a, int b)
	{
		if(b == 0)
			throw new DivideByZeroException();

		return a / b;
	}
}
