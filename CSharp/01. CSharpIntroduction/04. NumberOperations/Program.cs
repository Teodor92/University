namespace _04.NumberOperations
{
    using System;
    using System.Globalization;
    using System.Linq;

    using Homework.Common;

    public class Program
    {
        private const string SumMessage = "The sum of the digits of {0} is {1}";
        private const string ReversedMessage = "The revers image of the digits of {0} is {1}";
        private const string FirstDigitsSwitchMessage = "The switched image of the first digits of {0} is {1}";
        private const string SecondDigitsSwitchMessage = "The switched image of the second digits of {0} is {1}";

        internal static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input != null)
            {
                var sumMessage = string.Format(SumMessage, input, FindDigitSum(input));
                ConsoleOutputHelper.WriteMessage(sumMessage, ConsoleMessageType.Success);

                var reversedDigits = string.Join(string.Empty, input.Reverse());
                var reverseMessage = string.Format(ReversedMessage, input, reversedDigits);
                ConsoleOutputHelper.WriteMessage(reverseMessage, ConsoleMessageType.Success);

                var firstDigitsSwitchMessage = string.Format(FirstDigitsSwitchMessage, input, SwitchFirstDigits(input));
                ConsoleOutputHelper.WriteMessage(firstDigitsSwitchMessage, ConsoleMessageType.Success);

                var secondDigitsSwitchMessage = string.Format(SecondDigitsSwitchMessage, input, SwitchSecondDigits(input));
                ConsoleOutputHelper.WriteMessage(secondDigitsSwitchMessage, ConsoleMessageType.Success);
            }
        }

        private static int FindDigitSum(string input)
        {
            var digits = input.ToArray();
            var sum = digits.Sum(x => int.Parse(x.ToString(CultureInfo.InvariantCulture)));
            return sum;
        }

        private static string SwitchFirstDigits(string input)
        {
            string newString = string.Format("{0}{1}{2}{3}", input[3], input[1], input[2], input[0]);
            return newString;
        }

        private static string SwitchSecondDigits(string input)
        {
            string newString = string.Format("{0}{1}{2}{3}", input[0], input[2], input[1], input[3]);
            return newString;
        }
    }
}
