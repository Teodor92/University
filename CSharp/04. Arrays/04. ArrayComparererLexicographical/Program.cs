namespace _04.ArrayComparererLexicographical
{
    using System;

    /// <summary>
    /// Compares two char arrays lexicographically and tells which one comes first.
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            var firstArray = new char[12];
            var secondArray = new char[12];

            Console.WriteLine(string.Compare(firstArray.ToString(), secondArray.ToString(), StringComparison.Ordinal));
        }
    }
}
