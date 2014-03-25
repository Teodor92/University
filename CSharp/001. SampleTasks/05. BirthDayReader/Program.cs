namespace BirthDayReader
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        internal static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

            var astralSignsStatistic = new Dictionary<string, int>();

            using (var reader = new StreamReader(@"../../Birthdays.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    var birthday = new DateTime();

                    if (DateTime.TryParse(line, out birthday))
                    {
                        var astralSign = GetAstralSign(birthday);
                        if (astralSignsStatistic.ContainsKey(astralSign))
                        {
                            astralSignsStatistic[astralSign]++;
                        }
                        else
                        {
                            astralSignsStatistic.Add(astralSign, 1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid BirthDay");
                    }
                }
            }

            Console.WriteLine("Summary");

            foreach (var sign in astralSignsStatistic)
            {
                Console.WriteLine("Sign: {0}, Number: {1}", sign.Key, sign.Value);
            }
        }

        private static string GetAstralSign(DateTime birthday)
        {
            int month = birthday.Month;
            int day = birthday.Day;
            switch (month)
            {
                case 1:
                    if (day <= 19)
                    {
                        return "Capricorn";
                    }

                    return "Aquarius";

                case 2:
                    if (day <= 18)
                    {
                        return "Aquarius";
                    }

                    return "Pisces";
                case 3:
                    if (day <= 20)
                    {
                        return "Pisces";
                    }

                    return "Aries";
                case 4:
                    if (day <= 19)
                    {
                        return "Aries";
                    }

                    return "Taurus";
                case 5:
                    if (day <= 20)
                    {
                        return "Taurus";
                    }

                    return "Gemini";
                case 6:
                    if (day <= 20)
                    {
                        return "Gemini";
                    }

                    return "Cancer";
                case 7:
                    if (day <= 22)
                    {
                        return "Cancer";
                    }

                    return "Leo";
                case 8:
                    if (day <= 22)
                    {
                        return "Leo";
                    }

                    return "Virgo";
                case 9:
                    if (day <= 22)
                    {
                        return "Virgo";
                    }

                    return "Libra";
                case 10:
                    if (day <= 22)
                    {
                        return "Libra";
                    }

                    return "Scorpio";
                case 11:
                    if (day <= 21)
                    {
                        return "Scorpio";
                    }

                    return "Sagittarius";
                case 12:
                    if (day <= 21)
                    {
                        return "Sagittarius";
                    }

                    return "Capricorn";
            }

            return string.Empty;
        }
    }
}
