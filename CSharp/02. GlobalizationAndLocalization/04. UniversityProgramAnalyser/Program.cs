namespace _04.UniversityProgramAnalyser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Counts how many times a chosen day of week is repeated between two dates
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            var startDate = new DateTime(2014, 1, 1);
            var endDate = new DateTime(2014, 2, 2);

            var result = (endDate - startDate).Days;
            var currentDay = startDate;
            var numberOfDays = 0;

            for (var i = startDate; i != endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Thursday)
                {
                    numberOfDays++;
                }
            }

            Console.WriteLine(numberOfDays);
        }
    }
}
