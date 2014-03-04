namespace _01.ArrayInitializer
{
    using Homework.Common;

    /// <summary>
    /// Creates an array of 20 int objects  and initializes each of them with a value equal to the product of 
    /// its index and 5. Then print all the elements of the array in the console
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            var sampleArray = new int[20];

            for (int i = 0; i < sampleArray.Length; i++)
            {
                sampleArray[i] = i * 5;
            }

            ConsoleOutputHelper.WriteMessage(string.Join(", ", sampleArray), ConsoleMessageType.Success);
        }
    }
}
