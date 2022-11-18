using SimpleCalc;
using Xunit;

public class TestClass
{
    private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
    [Fact]

    public void AddsTwoNumberAndReturnsValidResultsForNonSymbolOperation()
    {
        int number1 = 1;
        int number2 = 2;
        double result = _calculatorEngine.Calculate("add", number1, number2);
        Assert.Equal(3, result);
    }
    public void AddsTwoNumberAndReturnsValidResultsForSymbolOperation()
    {
        int number1 = 1;
        int number2 = 2;
        double result = _calculatorEngine.Calculate("+", number1, number2);
        Assert.Equal(3, result);
    }
}
