namespace _03.ArrayRead
{
    using System.Linq;

    using Homework.Common;

    /// <summary>
    /// Reads two int arrays from the console and checks if they have equal elements (in any position). 
    /// Put the equals elements in another array and print the highest value of them.
    /// </summary>
    public class Program
    {
        private const string FirstArraySizeMessage = "Enter the size of the first array";
        private const string SecondArraySizeMessage = "Enter the size of the second array";
        private const string EnterElementMessage = "Enter the {0} element";
        private const string BiggestElementMessage = "The biggest element is {0}";

        internal static void Main(string[] args)
        {
            var firstArraySize = ConsoleInputHelper.SafeRead<int>(FirstArraySizeMessage);
            var firstArray = new int[firstArraySize];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = ConsoleInputHelper.SafeRead<int>(string.Format(EnterElementMessage, i));
            }

            var secondArraySize = ConsoleInputHelper.SafeRead<int>(SecondArraySizeMessage);
            var secondArray = new int[secondArraySize];

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = ConsoleInputHelper.SafeRead<int>(string.Format(EnterElementMessage, i));
            }

            var equalElements = firstArray.Where(secondArray.Contains).ToList();

            ConsoleOutputHelper.WriteMessage(string.Format(BiggestElementMessage, equalElements.Max()), ConsoleMessageType.Success);
        }
    }
}
