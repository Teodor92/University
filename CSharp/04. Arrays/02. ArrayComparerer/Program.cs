using System.Linq;

namespace _02.ArrayComparerer
{
    using System;

    /// <summary>
    /// Reads two arrays from the console and 
    /// checks if they are the same (compare the values of the elements in corresponding positions). 
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            bool areEqual = true;
            var firstArray = new int[12];
            var secondArray = new int[12];

            if (firstArray.SequenceEqual(secondArray))
            {
                Console.WriteLine("Ravni");
            }
        }
    }
}
