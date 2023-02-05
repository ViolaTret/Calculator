using System;

namespace Calculator
{
    internal static class MathOperation
    {
        private static string Add(string firstNumber, string secondNumber)
        {
            return Convert.ToString(Convert.ToDouble(firstNumber) + Convert.ToDouble(secondNumber));
        }

        private static string Sub(string firstNumber, string secondNumber)
        {
            return Convert.ToString(Convert.ToDouble(firstNumber) - Convert.ToDouble(secondNumber));
        }

        private static string Multiply(string firstNumber, string secondNumber)
        {
            return Convert.ToString(Convert.ToDouble(firstNumber) * Convert.ToDouble(secondNumber));
        }

        private static string Divide(string firstNumber, string secondNumber)
        {
            return Convert.ToString(Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber));
        }

        private static string Percentage(string firstNumber, string secondNumber)
        {
            return Convert.ToString(Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber) * 100);
        }

        private static string Sqrt(string number)
        {
            return Convert.ToString(Math.Sqrt(Convert.ToDouble(number)));
        }

        private static string Pow(string number)
        {
            return Convert.ToString(Math.Pow(Convert.ToDouble(number), 2));
        }

        private static string FlipFraction(string number)
        {
            return Convert.ToString(1 / Convert.ToDouble(number));
        }

        public static string RunOperationForTwoNumbers(string firstNumber, string secondNumber, string operation)
        {
            switch (operation)
            {
                case "+":
                    return Add(firstNumber, secondNumber);
                case "-":
                    return Sub(firstNumber, secondNumber);
                case "×":
                    return Multiply(firstNumber, secondNumber);
                case "÷":
                    return Divide(firstNumber, secondNumber);
                case "%":
                    return Percentage(firstNumber, secondNumber);
                default:
                    return "";
            }
        }

        public static string RunOperationForOneNumbers(string number, string operation)
        {
            switch (operation)
            {
                case "√":
                    return Sqrt(number);
                case "x²":
                    return Pow(number);
                case "1/x":
                    return FlipFraction(number);
                default:
                    return "";
            }
        }
    }
}
