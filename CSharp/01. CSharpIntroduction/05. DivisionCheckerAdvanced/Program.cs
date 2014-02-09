namespace _05.DivisionCheckerAdvanced
{
    using System.Text;

    using Homework.Common;

    /// <summary>
    /// Prints all the numbers divisible by 3,4 and 9 within a given range.
    /// </summary>
    public class Program
    {
        private const string IntervalStartPromt = "Please enter the start of the interval";
        private const string IntervalEndPromt = "Please enter the end of the interval";
        private const string DivisorChousePromt = "Please chouse a divisor - 3, 4 or 9.";
        private const string InvalidDivisorPromt = "Divisor is invalid. Please try again.";

        internal static void Main(string[] args)
        {
            var intervalStart = ConsoleInputHelper.SafeRead<int>(IntervalStartPromt);
            var intervalEnd = ConsoleInputHelper.SafeRead<int>(IntervalEndPromt);

            while (true)
            {
                var divisor = ConsoleInputHelper.SafeRead<int>(DivisorChousePromt);
                var isDivisorValid = divisor == 3 || 
                                     divisor == 4 || 
                                     divisor == 9;

                if (!isDivisorValid)
                {
                    ConsoleOutputHelper.WriteMessage(InvalidDivisorPromt, ConsoleMessageType.Error);
                }
                else
                {
                    var numbers = GetAllDivisableNumbers(intervalStart, intervalEnd, divisor);
                    ConsoleOutputHelper.WriteMessage(numbers, ConsoleMessageType.Success);

                    break;
                }
            }
        }

        private static string GetAllDivisableNumbers(int intervalsStart, int intervalEnd, int divisor)
        {
            var output = new StringBuilder();

            for (int i = intervalsStart; i < intervalEnd; i++)
            {
                if (i % divisor == 0)
                {
                    output.AppendFormat("{0} ", i);
                }
            }

            return output.ToString().Trim();
        }
    }
}