namespace _08.HighestSumFinder
{
    using System;

    using Homework.Common;

    /// <summary>
    /// Reads two int numbers from the console N and K (K less than N), and an array of N elements. 
    /// Finds the sequence of K elements that have the highest sum. 
    /// </summary>
    public class Program
    {
        private const string ArrayLengthPromptMessage = "Enter length for array: ";
        private const string SequanceLengthMessage = "Enter count of numbers in the sequence: ";
        private const string ElementAtPositionMessage = "Enter element at position {0}: ";

        internal static void Main(string[] args)
        {
            var arrayLength = ConsoleInputHelper.SafeRead<int>(ArrayLengthPromptMessage);
            var sequenceCount = ConsoleInputHelper.SafeRead<int>(SequanceLengthMessage);
            var array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = ConsoleInputHelper.SafeRead<int>(string.Format(ElementAtPositionMessage, i));
            }

            var maxSum = 0;
            var maxIndex = -1;

            for (int i = 0; i < arrayLength - sequenceCount + 1; i++)
            {
                var currentSum = 0;

                for (int j = 0; j < sequenceCount; j++)
                {
                    currentSum += array[i + j];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxIndex = i;
                }
            }

            Console.Write("The sequence of {0} elements with maximal sum is:  ", sequenceCount);

            for (int i = maxIndex; i < maxIndex + sequenceCount; i++)
            {
                Console.Write(" {0}; ", array[i]);
            }

            Console.WriteLine();
        }
    }
}
