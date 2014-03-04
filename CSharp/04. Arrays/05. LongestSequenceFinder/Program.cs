namespace _05.LongestSequenceFinder
{
    using System;

    using Homework.Common;

    /// <summary>
    /// Finds the longest sequence of equal elements in an array. 
    /// </summary>
    /// <example>
    /// {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} => {2, 2, 2}
    /// </example>
    public class Program
    {
        private const string ArreyLengthPromptMessage = "Enter length for array: ";
        private const string ElementAtPositionMessage = "Enter element at position {0}: ";

        internal static void Main(string[] args)
        {
            var arrayLength = ConsoleInputHelper.SafeRead<int>(ArreyLengthPromptMessage);
            var array = new int[arrayLength];

            var currentLength = 1;
            var currentSequenceNumber = 0;
            var maxSequenceNumber = 0;
            var maxLength = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ConsoleInputHelper.SafeRead<int>(string.Format(ElementAtPositionMessage, i));

                if (i == 0)
                {
                    currentSequenceNumber = array[i];
                    maxSequenceNumber = currentSequenceNumber;
                    continue;
                }

                if (currentSequenceNumber == array[i])
                {
                    currentLength++;

                    if (currentLength >= maxLength)
                    {
                        maxLength = currentLength;
                        maxSequenceNumber = currentSequenceNumber;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentSequenceNumber = array[i];
                }
            }

            Console.Write("Largest sequence:{");

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(" {0} ", maxSequenceNumber);
            }

            Console.WriteLine("}");
        }
    }
}
