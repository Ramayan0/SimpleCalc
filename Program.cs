using SimpleCalc;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            double firstNum = inputConverter.ConvertInputToNum(Console.ReadLine());
            double SecondNum = inputConverter.ConvertInputToNum(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation, firstNum, SecondNum);
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            // in real worl we would want to log this message
            Console.WriteLine(ex.Message);
        }


    }
}
