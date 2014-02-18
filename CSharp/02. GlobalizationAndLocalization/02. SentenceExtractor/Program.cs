namespace _02.SentenceExtractor
{
    using System;
    using System.Linq;

    using Homework.Common;

    /// <summary>
    /// Prints all sentences from some text, 
    /// containing a particular word. Consider that all sentences are separated by  "."
    /// </summary>
    public class Program
    {
        private const string GreetingMessage = "Enter all the sentance separtad by '.'.";
        private const string SearchWordPromt = "Enter a word to search for.";

        internal static void Main(string[] args)
        {
            var userText = ConsoleInputHelper.SafeRead<string>(GreetingMessage);
            var searchWord = ConsoleInputHelper.SafeRead<string>(SearchWordPromt);

            var setnaces = userText.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var setnace in setnaces)
            {
                if (setnace.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Any(x => x == searchWord))
                {
                    Console.WriteLine(setnace.Trim());
                }
            }
        }
    }
}
