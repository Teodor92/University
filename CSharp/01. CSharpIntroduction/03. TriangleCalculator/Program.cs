namespace _03.TriangleCalculator
{
    using System.Linq;

    using Homework.Common;

    /// <summary>
    /// Calculates the perimetr and the area ot a triangle.
    /// </summary>
    public class Program
    {
        private const int TriangleNumberOfSides = 3;
        private const string SidePromtMessage = "Enter side number {0}.";
        private const string AreaSuccessMessage = "The area of the tringle is {0}";
        private const string PerimeterSuccessMessage = "The perimeter of the tringle is {0}";

        internal static void Main(string[] args)
        {
            var sides = new double[TriangleNumberOfSides];
            for (int i = 0; i < TriangleNumberOfSides; i++)
            {
                var promtMessage = string.Format(SidePromtMessage, i + 1);
                sides[i] = ConsoleInputHelper.SafeRead<double>(promtMessage);
            }

            var perimeter = sides.Sum();
            var area = sides.Aggregate((a, b) => a * b);

            var areaMessage = string.Format(AreaSuccessMessage, area);
            var perimeterMessage = string.Format(PerimeterSuccessMessage, perimeter);
            ConsoleOutputHelper.WriteMessage(areaMessage, ConsoleMessageType.Success);
            ConsoleOutputHelper.WriteMessage(perimeterMessage, ConsoleMessageType.Success);
        }
    }
}
