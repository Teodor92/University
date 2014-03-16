namespace _01.ArrayIndices
{
    using System;

    public class Program
    {
        internal static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Enter length for the array: ");
            } 
            while (!int.TryParse(Console.ReadLine().Trim(), out n));

            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("Enter element for the array at position {0}: ", i);
                } 
                while (!int.TryParse(Console.ReadLine().Trim(), out array[i]));
            }

            var minNumber = int.MaxValue;
            var minNumberLastIndex = -1;
            var minNumberCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                {
                    minNumberCount = 1;
                    minNumber = array[i];
                    minNumberLastIndex = i;
                }
               else if (minNumber == array[i])
                {
                    minNumberCount++;
                    minNumberLastIndex = i;
                }
            }

            // The result array should not contain the indices of elemetns with contain the minimal value and
            // and indices that are after the last index of the minimal number
            var indicesArray = new int[array.Length - minNumberCount - (array.Length - minNumberLastIndex) + 1];

            int currentIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > minNumber && i < minNumberLastIndex)
                {
                    indicesArray[currentIndex] = i;
                    currentIndex++;
                }
            }

            // Display result
            Console.Write("Result array with indices: ");
            
            foreach (var t in indicesArray)
            {
                Console.Write("{0} ", t);
            }

            Console.WriteLine();
        }
    }
}
