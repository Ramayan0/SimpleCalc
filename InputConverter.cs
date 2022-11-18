using System;

namespace SimpleCalc
{
    public class InputConverter
    {
        public double ConvertInputToNum(string argTextInput)
        {
            // // original input
            double convertedNum;
            bool converter = double.TryParse(argTextInput, out convertedNum);
            if (!converter) throw new ArgumentException("Excepted a numeric value");
            return convertedNum;

            // using out you dont have to declare a variable first
            // if (!double.TryParse(argTextInput, out double convertedNum)) throw new ArgumentException("Excepted a numeric value");
            // return convertedNum;

            // // Throw Expression  can be used in ternary operator and null coalescing
            // return double.TryParse(argTextInput, out double convertedNum) ? convertedNum : throw new ArgumentException("Excepted a numeric value");
            // var option = Console.ReadLine() ?? throw new Exception("blah blah");
        }
    }
}
