namespace _02.ArrayComparerer
{
    using System.Linq;
    using Homework.Common;

    /// <summary>
    /// Reads two arrays from the console and 
    /// checks if they are the same (compare the values of the elements in corresponding positions). 
    /// </summary>
    public class Program
    {
        private const string AreEqualMessage = "The too arrays are equal.";
        private const string AreNotEqualMessage = "The too arrays are NOT equal";

        internal static void Main(string[] args)
        {
            var firstArray = new int[12];
            var secondArray = new int[12];

            if (firstArray.SequenceEqual(secondArray))
            {
                ConsoleOutputHelper.WriteMessage(AreEqualMessage, ConsoleMessageType.Success);
            }
            else
            {
                ConsoleOutputHelper.WriteMessage(AreNotEqualMessage, ConsoleMessageType.Warrning);
            }
        }
    }
}
