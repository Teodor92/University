namespace _02.ArrayTask
{
    using System;

    public class Program
    {
        internal static void Main(string[] args)
        {
            var n = -1;
            var nthString = string.Empty;
            var valid = false;

            do
            {
                Console.Write("Enter a number between 10 and 50: ");
                nthString = Console.ReadLine().Trim();
                valid = int.TryParse(nthString, out n);
                valid = valid && n > 10;
                valid = valid && n < 50;
            } 
            while (!valid);

            var x = -1;
            var y = -1;
            var stringXy = string.Empty;

            do
            {
                Console.Write("Enter two numbers X and Y where X < Y (on THE SAME LINE separated by an interval/space): ");
                stringXy = Console.ReadLine();
                string[] stringArray = stringXy.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                valid = int.TryParse(stringArray[0], out x) && int.TryParse(stringArray[1], out y);
                valid = valid && x < y;
            } 
            while (!valid);

            var inputArray = new int[n];

            int validNumbersCount = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                do
                {
                    Console.Write("Enter element for the array at position {0}: ", i);
                } 
                while (int.TryParse(Console.ReadLine().Trim(), out inputArray[i]));

                if ((inputArray[i] >= x && inputArray[i] <= y) || inputArray[i] > i || i % 3 == 0)
                {
                    validNumbersCount++;
                }
            }

            var validNumbers = new int[validNumbersCount];
            var currentIndex = 0;
            var sum = 0;
            var product = 1;
            var maxValue = int.MinValue;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if ((inputArray[i] >= x && inputArray[i] <= y) || inputArray[i] > i || i % 3 == 0)
                {
                    validNumbers[currentIndex] = inputArray[i];
                    sum += validNumbers[currentIndex];
                    product *= validNumbers[currentIndex];

                    if (maxValue < validNumbers[currentIndex])
                    {
                        maxValue = validNumbers[currentIndex];
                    }

                    currentIndex++;
                }
            }

            Console.Write("Input array: ");

            foreach (var t in inputArray)
            {
                Console.Write("{0} ", t);
            }

            Console.WriteLine();

            Console.Write("Result array: ");

            for (int i = 0; i < validNumbers.Length; i++)
            {
                Console.Write("{0} ", validNumbers[i]);
            }

            Console.WriteLine();
            Console.WriteLine(
                "Result array specs -> Count: {0}; Sum: {1}; Product: {2}; Maximum value: {3}",
                validNumbersCount, 
                sum, 
                product, 
                maxValue);
        }
    }
}