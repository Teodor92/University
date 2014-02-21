namespace _05.SSNAnalyser
{
    using System;
    using System.Globalization;
    using System.Threading;

    using Homework.Common;

    /// <summary>
    /// Extract someone’s gender, age, date of birth and number of days until their next birthday for Personal ID. 
    /// </summary>
    public class Program
    {
        private const string PinInputGreeting = "Please enter your pin";
        private const string InvalidPinPromt = "Invalid pin. Please try again";

        internal static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            ExtractBirthDateFormString("9204028463");

            string pinString;

            while (true)
            {
                pinString = ConsoleInputHelper.SafeRead<string>(PinInputGreeting);

                var parsedPin = 0L;
                var isNummeric = long.TryParse(pinString, out parsedPin);
                var isCorrectLength = pinString.Length == 10;

                if (isNummeric && isCorrectLength)
                {
                    break;
                }

                ConsoleOutputHelper.WriteMessage(InvalidPinPromt, ConsoleMessageType.Error);
            }

            var birthDay = ExtractBirthDateFormString(pinString);
            var gender = ExtractGender(pinString);
            var age = ExtratAge(pinString);
            var daysUntilBirthDay = ExtractDaysUntilBirthDay(pinString);

            var message =
                string.Format(
                    "The person wtih the PIN {0} is {1} and is born on: {2}. He is {3} years old and has {4} days until his birthday.",
                    pinString, 
                    gender, 
                    birthDay.ToString("dd/MM/yyyy"), 
                    age, 
                    daysUntilBirthDay);

            ConsoleOutputHelper.WriteMessage(message, ConsoleMessageType.Success);
        }

        private static DateTime ExtractBirthDateFormString(string pin)
        {
            var year = int.Parse(pin.Substring(0, 2));
            var month = int.Parse(pin.Substring(2, 2));
            var day = int.Parse(pin.Substring(4, 2));

            if (month > 20)
            {
                year += 1800;
            }
            else if (month > 40)
            {
                year += 2000;
            }
            else
            {
                year += 1900;
            }

            var birthDay = new DateTime(year, month, day);
            return birthDay;
        }

        private static int ExtratAge(string pin)
        {
            const double ApproxDaysPerYear = 365.25;

            var birthDay = ExtractBirthDateFormString(pin);
            var age = (int)((DateTime.Now - birthDay).Days / ApproxDaysPerYear);

            return age;
        }

        private static int ExtractDaysUntilBirthDay(string pin)
        {
            var birthDay = ExtractBirthDateFormString(pin);
            var today = DateTime.Today;
            var next = birthDay.AddYears(today.Year - birthDay.Year);

            if (next < today)
            {
                next = next.AddYears(1);
            }

            int numberOfDays = (next - today).Days;

            return numberOfDays;
        }

        private static Gender ExtractGender(string pin)
        {
            var genderDigit = (int)char.GetNumericValue(pin[8]);

            if (genderDigit % 2 == 0)
            {
                return Gender.Male;
            }
            else
            {
                return Gender.Female;
            }
        }
    }
}
