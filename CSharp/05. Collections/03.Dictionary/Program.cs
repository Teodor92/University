namespace _03.Dictionary
{
    using System;
    using System.Collections.Specialized;

    public class Program
    {
        internal static void Main(string[] args)
        {
            string dictionaryType = string.Empty;

            do
            {
                Console.Write("Enter \"a\" for synonym, \"b\" for encyclopedic and \"c\"" +
                " for bulgarian-english dictionary: ");

                dictionaryType = Console.ReadLine().Trim();
            } 
            while (!(dictionaryType.Equals("a") || dictionaryType.Equals("b") || dictionaryType.Equals("c")));

            var dictionary = new StringDictionary();

            Console.WriteLine("Dictionary usage: To enter a word and a translation type in: add <word> - <translation>");
            Console.WriteLine("Dictionary usage: To search for a word type in: search <word>");
            Console.WriteLine("Dictionary usage: To search exit the program type in: exit");

            string input = Console.ReadLine();

            while (!input.Equals("exit"))
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                input = input.ToLower().Trim();
                string[] words = input.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                string operation = words[0];
                    string word = words[1];
                
                if (operation == "add")
                {
                    string translation = words[2];
                    dictionary.Add(word, translation);
                    Console.WriteLine("Word {0} with translation {1} added successfully.", word, translation);
                }
                else if (operation == "search")
                {
                    if (dictionary.ContainsKey(word))
                    {
                        string existingTranslation = dictionary[word];
                        Console.WriteLine("{0} - {1}", word, existingTranslation);
                    }
                    else
                    {
                        Console.WriteLine("Translation does not exist for the given word.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please try again.");
                }

                input = Console.ReadLine();
            }
        }
    }
}
