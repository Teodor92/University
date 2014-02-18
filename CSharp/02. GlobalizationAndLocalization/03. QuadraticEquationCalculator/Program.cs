namespace _03.QuadraticEquationCalculator
{
    using System;

    using Homework.Common;

    /// <summary>
    /// Calculates the roots of a quadratic equation entered in the following format  ax^2+bx+c=0. 
    /// </summary>
    public class Program
    {
        private const string GreetingMessage = "Enter a quadratic equation to solve.";
        private const string NoRootsMessage = "The equation has no roots.";
        private const string OneRootsMessage = "The equation has one root - X1,2 {0}.";
        private const string TwoRootsMessage = "The eqiation has two roots. X1 = {0} and X2 = {1}.";

        internal static void Main(string[] args)
        {
            var rawEqation = ConsoleInputHelper.SafeRead<string>(GreetingMessage);
            var rawIndexes = rawEqation.Split(new[] { "x^2+", "x+", "=0" }, StringSplitOptions.RemoveEmptyEntries);
            var solution = SolveQuadraticEquation(double.Parse(rawIndexes[0]), double.Parse(rawIndexes[1]), double.Parse(rawIndexes[2]));
            ConsoleOutputHelper.WriteMessage(solution, ConsoleMessageType.Success);
        }

        private static string SolveQuadraticEquation(double indexA, double indexB, double indexC)
        {
            var discriminant = (indexB * indexB) - (4 * indexA * indexC);

            if (discriminant > 0)
            {
                var firstRoot = (-indexB + Math.Sqrt(discriminant)) / (indexA * 2);
                var secondRoot = (-indexB - Math.Sqrt(discriminant)) / (indexA * 2);
                return string.Format(TwoRootsMessage, firstRoot, secondRoot);
            }
            else if (discriminant < 0)
            {
                return NoRootsMessage;
            }
            else
            {
                var root = -(indexA / 2 * indexB);
                return string.Format(OneRootsMessage, root);
            }
        }
    }
}
