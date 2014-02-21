namespace Homework.Common
{
    using System;

    using Homework.Common.Extentions;

    public class ConsoleInputHelper
    {
        private const string IntReadDefaultGreetingMessage = "Hello! Please enter a desired input.";
        private const string IntReadDefaultErrorMessage = "Invalid input. Please try again.";

        /// <summary>
        /// Safely reads a T type form the console. If the input is 
        /// invalid outputs an error message and prompt for another input.
        /// </summary>
        /// <typeparam name="T">The type witch will be read form the console</typeparam>
        /// <param name="greetingMessage">Greeting message for the read start.</param>
        /// <param name="errorMessage">Error message if the parsing fails.</param>
        /// <returns>Returns the parsed T type.</returns>
        public static T SafeRead<T>(
            string greetingMessage = IntReadDefaultGreetingMessage,
            string errorMessage = IntReadDefaultErrorMessage)
        {
            while (true)
            {
                Console.WriteLine(greetingMessage);
                string input = Console.ReadLine();

                try
                {
                    var inputNumber = input.Convert<T>();
                    return inputNumber;
                }
                catch (Exception)
                {
                    ConsoleOutputHelper.WriteMessage(errorMessage, ConsoleMessageType.Error);
                }
            }
        }
    }
}
