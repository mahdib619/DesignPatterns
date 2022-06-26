using Strategy.Operations.Abstract;
using Strategy.Operations.Concrete;

namespace Strategy;

public class Calculator
{
	public IMathOperation Operator { get; set; } = new SumOperation();

	public int Calculate(int a, int b)
	{
		return Operator.Operate(a, b);
	}
}
