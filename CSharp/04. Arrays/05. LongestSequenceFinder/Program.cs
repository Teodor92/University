using System.Globalization;
using System.Text;
using Homework.Common;

namespace _05.LongestSequenceFinder
{
    /// <summary>
    /// Finds the longest sequence of equal elements in an array. 
    /// </summary>
    /// <example>
    /// {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} => {2, 2, 2}
    /// </example>
    public class Program
    {
        internal static void Main(string[] args)
        {
            var bestSequance = string.Empty;
            var currentSequnce = new StringBuilder();
            var bestSequenceCount = int.MinValue;
            var currentSequenceCount = 1;
            var sampleArray = new[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            for (int i = 0; i < sampleArray.Length - 1; i++)
            {
                if (sampleArray[i] == sampleArray[i + 1])
                {
                    currentSequenceCount++;
                    currentSequnce.AppendFormat("{0}, ", sampleArray[i]);
                }
                else
                {
                    if (bestSequenceCount < currentSequenceCount)
                    {
                        bestSequenceCount = currentSequenceCount;
                        bestSequance = currentSequnce.ToString().Trim(',');
                        currentSequnce.Clear();
                    }

                    currentSequenceCount = 1;
                }
            }

            ConsoleOutputHelper.WriteMessage(bestSequance);
        }
    }
}
