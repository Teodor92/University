namespace _07.LongestArithmeticProgressionFinder
{
    using System;
    using System.Collections.Generic;

    using Homework.Common;

    /// <summary>
    /// Finds the longest sequence of elements in arithmetic progression. 
    /// The elements may not be ordered in the array.
    /// </summary>
    /// <example>
    /// {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} => {2, 4, 6, 8}
    /// </example>
    public class Program
    {
        private const string ArrayLengthPromptMessage = "Enter length for array: ";
        private const string ElementAtPositionMessage = "Enter element at position {0}: ";

        internal static void Main(string[] args)
        {
            var arrayLength = ConsoleInputHelper.SafeRead<int>(ArrayLengthPromptMessage);

            var array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = ConsoleInputHelper.SafeRead<int>(string.Format(ElementAtPositionMessage, i));
            }

            var maxList = new List<int>();

            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    var currentDifference = array[j] - array[i];

                    var currentList = new List<int>();

                    currentList.Add(array[i]);
                    currentList.Add(array[j]);
                    var currentBorderNumber = array[j];

                    for (int k = j + 1; k < array.Length; k++)
                    {
                        if (array[k] - currentBorderNumber == currentDifference)
                        {
                            currentList.Add(array[k]);
                            currentBorderNumber = array[k];
                        }
                    }

                    if (currentList.Count > maxList.Count)
                    {
                        maxList = currentList;
                    }
                }
            }

            Console.Write("The largest increasing arithmetic progression is: ");

            foreach (var number in maxList)
            {
                Console.Write(" {0} ", number);
            }

            Console.WriteLine();
        }
    }
}
