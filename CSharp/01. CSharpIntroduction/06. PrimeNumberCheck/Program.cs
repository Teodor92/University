namespace _06.PrimeNumberCheck
{
    using System;

    using Homework.Common;

    /// <summary>
    /// Checks if a give number is prime.
    /// </summary>
    public class Program
    {
        private const string EnterNumberPrompt = "Enter a number to check if its prime:";
        private const string AlgorithmChoosePrompt = "Please chouse an algorithm 1 for Square root 2 for Half";
        private const string InlvaidChoicePrompt = "Invalid choise! Please try again.";
        private const string IsPrimePrompt = "The number {0} is prime!";
        private const string IsNotPrimePrompt = "The number {0} is NOT prime!";

        internal static void Main(string[] args)
        {
            var inputNumber = ConsoleInputHelper.SafeRead<int>(EnterNumberPrompt);

            while (true)
            {
                var choice = ConsoleInputHelper.SafeRead<int>(AlgorithmChoosePrompt);
                var choiseIsValid = choice == 1 || choice == 2;

                if (choiseIsValid)
                {
                    RunAlgorithm(choice, inputNumber);
                    break;
                }

                ConsoleOutputHelper.WriteMessage(InlvaidChoicePrompt, ConsoleMessageType.Error);
            }
        }

        private static void RunAlgorithm(int choice, int inputNumber)
        {
            bool result;

            if (choice == 1)
            {
                result = SquareRootPrimeAlgorithm(inputNumber);
            }
            else
            {
                result = HalfPrimeAlgorithm(inputNumber);
            }

            if (result)
            {
                var message = string.Format(IsPrimePrompt, inputNumber);
                ConsoleOutputHelper.WriteMessage(message, ConsoleMessageType.Success);
            }
            else
            {
                var message = string.Format(IsNotPrimePrompt, inputNumber);
                ConsoleOutputHelper.WriteMessage(message, ConsoleMessageType.Warrning);
            }
        }

        private static bool SquareRootPrimeAlgorithm(int inputNumber)
        {
            for (int i = 2; i < Math.Sqrt(inputNumber); i++)
            {
                if (inputNumber % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool HalfPrimeAlgorithm(int inputNumber)
        {
            for (int i = 2; i < inputNumber / 2; i++)
            {
                if (inputNumber % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
