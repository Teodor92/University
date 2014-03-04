namespace _06.LongestConsecutiveSequenceFinder
{
    using System;
    using System.Linq;

    using Homework.Common;

    /// <summary>
    /// Finds the longest sequence of consecutive numbers in an array. 
    /// </summary>
    /// <example>
    /// {3, 2, 3, 4, 2, 2, 4} => {2, 3, 4}
    /// </example>
    public class Program
    {
        private const string ArrayLengthPromptMessage = "Enter length for array: ";
        private const string ArrayValuesPrompt = "Enter values for the array here:";
        private const string ElementAtPositionMessage = "Enter element at position {0}: ";
        private const string NoSequanceMesssage = "There is no sequence in the array.";
        private const string MaxSequanceMesssage = "The maximal increasing sequence in the array is/are:";

        internal static void Main(string[] args)
        {
            var length = ConsoleInputHelper.SafeRead<int>(ArrayLengthPromptMessage);
            var array = new int[length];
            var count = 1;
            var maxcount = 0;
            var maxcountNumbers = 1;
            var lastNumber = 0;
            var sequences = new int[length];

            ConsoleOutputHelper.WriteMessage(ArrayValuesPrompt);

            for (int i = 0; i < length; i++)
            {
                array[i] = ConsoleInputHelper.SafeRead<int>(string.Format(ElementAtPositionMessage, i));

                if (i > 0 && array[i] == array[i - 1] + 1)
                {
                    count++;

                    if (count > maxcount)
                    {
                        maxcount = count;
                        lastNumber = array[i];
                        Array.Clear(sequences, 0, length);
                        maxcountNumbers = 1;
                    }
                    else if (count == maxcount)
                    {
                        maxcountNumbers++;
                        sequences[i] = array[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            if (maxcountNumbers == 1)
            {
                if (maxcount <= 1)
                {
                    ConsoleOutputHelper.WriteMessage(NoSequanceMesssage, ConsoleMessageType.Warrning);
                }
                else
                {
                    ConsoleOutputHelper.WriteMessage(MaxSequanceMesssage, ConsoleMessageType.Success);

                    for (int i = maxcount - 1; i >= 0; i--)
                    {
                        Console.Write((lastNumber - i) + " ");
                    }
                }
            }
            else
            {
                ConsoleOutputHelper.WriteMessage(MaxSequanceMesssage, ConsoleMessageType.Success);

                for (int i = maxcount - 1; i >= 0; i--)
                {
                    Console.Write((lastNumber - i) + " ");
                }

                Console.WriteLine();

                foreach (int number in sequences.Where(number => number != 0))
                {
                    for (int i = maxcount - 1; i >= 0; i--)
                    {
                        Console.Write((number - i) + " ");
                    }
                }
            }
        }
    }
}
