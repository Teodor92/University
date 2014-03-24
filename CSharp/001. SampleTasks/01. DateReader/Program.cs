namespace _01.DateReader
{
    using System;
    using System.Globalization;

    public class Program
    {
        internal static void Main()
        {
            while (true)
            {
                Console.Write("Enter date(dd.mm.yyyy):");
                string rawString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(rawString))
                {
                    Console.WriteLine("END");
                    break;
                }

                DateTime anydate = DateTime.Parse(rawString);
                Console.WriteLine(anydate.ToString("dddd", CultureInfo.CreateSpecificCulture("bg-BG")));
                Console.WriteLine(anydate.ToString("dddd", CultureInfo.CreateSpecificCulture("en-GB")));
            }
        }
    }
}
