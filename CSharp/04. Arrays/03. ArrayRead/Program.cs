namespace _03.ArrayRead
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Reads two int arrays from the console and checks if they have equal elements (in any position). 
    /// Put the equals elements in another array and print the highest value of them.
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            var firstArray = new int[2];
            var secondArray = new int[2];
            var equalElements = new List<int>();

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (secondArray.Contains(firstArray[i]))
                {
                    equalElements.Add(firstArray[i]);
                }
            }

            Console.WriteLine(equalElements.Max());
        }
    }
}
