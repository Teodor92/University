namespace _04.ArrayComparererLexicographical
{
    using System;

    using Homework.Common;

    /// <summary>
    /// Compares two char arrays lexicographically and tells which one comes first.
    /// </summary>
    public class Program
    {
        private const string FirstArrayMessage = "Array number {0}, comes first.";
        private const string EqualArraysMessage = "The arrays are equal.";

        internal static void Main(string[] args)
        {
            var firstArray = new[] { 's', 'b', 'l', 'a' };
            var secondArray = new[] { 's', 'b', 'l', 'a' };
            var firstArrayAsString = string.Join(string.Empty, firstArray);
            var secondArrayAsString = string.Join(string.Empty, secondArray);
            var compareResult = string.Compare(firstArrayAsString, secondArrayAsString, StringComparison.Ordinal);

            if (compareResult > 0)
            {
                ConsoleOutputHelper.WriteMessage(string.Format(FirstArrayMessage, 1), ConsoleMessageType.Success);
            }
            else if (compareResult < 0)
            {
                ConsoleOutputHelper.WriteMessage(string.Format(FirstArrayMessage, 2), ConsoleMessageType.Success);
            }
            else
            {
                ConsoleOutputHelper.WriteMessage(EqualArraysMessage, ConsoleMessageType.Warrning);
            }
        }
    }
}
