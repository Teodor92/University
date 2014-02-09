namespace _01.OddOrEvenChecker
{
    using Homework.Common;

    /// <summary>
    /// Checks if a given number is even or odd
    /// </summary>
    public class Program
    {
        private const string GreetingMessage = "Hello! Please enter a number to chech if its even or ood";
        private const string ParsingErrorMessage = "Incorrect input. Pleas try again";
        private const string SuccessMessage = "{0} is {1}";

        internal static void Main(string[] args)
        {
            int inputNumber = ConsoleInputHelper.SafeRead<int>(GreetingMessage, ParsingErrorMessage);
            bool isEven = inputNumber % 2 == 0;
            string message = string.Format(SuccessMessage, inputNumber, isEven ? "Even" : "Odd");

            ConsoleOutputHelper.WriteMessage(message, ConsoleMessageType.Success);
        }
    }
}
