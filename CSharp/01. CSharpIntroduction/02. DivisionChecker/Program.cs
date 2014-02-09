namespace _02.DivisionChecker
{
    using Homework.Common;

    /// <summary>
    /// Checks if a number is divisible by 7 and 5
    /// </summary>
    /// <remarks>
    /// If the number is divisible by 35 its divisible by 7 and 5
    /// </remarks>
    public class Program
    {
        private const string SuccessMessage = "The number is divisible by 7 and 5";
        private const string FailMessage = "The number is NOT divisible by 7 and 5";

        internal static void Main(string[] args)
        {
            var inputNumber = ConsoleInputHelper.SafeRead<int>();

            if (inputNumber % 35 == 0)
            {
                ConsoleOutputHelper.WriteMessage(SuccessMessage, ConsoleMessageType.Success);
            }
            else
            {
                ConsoleOutputHelper.WriteMessage(FailMessage, ConsoleMessageType.Warrning);
            }
        }
    }
}
