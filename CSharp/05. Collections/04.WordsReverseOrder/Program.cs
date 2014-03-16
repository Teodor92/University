namespace _04.WordsReverseOrder
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Enter words, separated by space");
            string wordsString = Console.ReadLine();

            string[] wordsArray = wordsString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsStack = new Stack<string>();

            foreach (var t in wordsArray)
            {
                wordsStack.Push(t);
            }

            Console.WriteLine("Reverse order of the words is: ");

            while (wordsStack.Count > 0)
            {
                string currentWord = wordsStack.Pop();

                Console.Write("{0} ", currentWord);
            }

            Console.WriteLine();
        }
    }
}
