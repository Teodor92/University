namespace _04.UniversityProgramAnalyser
{
    using System;
    using System.Globalization;
    using System.Threading;

    using Homework.Common;

    /// <summary>
    /// Counts how many times a chosen day of week is repeated between two dates
    /// </summary>
    public class Program
    {
        private const string StartDatePrompt = "Please enter start date in dd/MM/yyyy format";
        private const string EndDatePrompt = "Please enter end date in dd/MM/yyyy format";
        private const string WrongFormatError = "Wrong date format";
        private const string DayOfTheWeekPrompt = "Please enter a day of the week - Monday, Sunday etc.";
        private const string DayOfTheWeekErrorMessage = "Invalid day of the week";

        internal static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var startDate = ConsoleInputHelper.SafeRead<DateTime>(StartDatePrompt, WrongFormatError);
            var endDate = ConsoleInputHelper.SafeRead<DateTime>(EndDatePrompt, WrongFormatError);
            var dayOfTheWeek = ConsoleInputHelper.SafeRead<DayOfWeek>(DayOfTheWeekPrompt, DayOfTheWeekErrorMessage);

            if (startDate > endDate)
            {
                var oldValue = startDate;
                startDate = endDate;
                endDate = oldValue;
            }

            var numberOfDays = 0;

            for (var i = startDate; i != endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek == dayOfTheWeek)
                {
                    numberOfDays++;
                }
            }

            var message = string.Format(
                "The number of {0} between {1} and {2} is {3}", 
                dayOfTheWeek, 
                startDate.ToString("dd/MM/yyyy"), 
                endDate.ToString("dd/MM/yyyy"), 
                numberOfDays);

            ConsoleOutputHelper.WriteMessage(message, ConsoleMessageType.Success);
        }
    }
}
