namespace _05.SquareMatrixes
{
    using System;

    public class Program
    {
        internal static void Main(string[] args)
        {
            string matrixType = string.Empty;

            do
            {
                Console.Write("Enter \"a\" or \"b\" to choose matrix type: ");
                matrixType = Console.ReadLine().Trim();
            } 
            while (!(matrixType.Equals("a") || matrixType.Equals("b")));

            int matrixLength = 0;
            string matrixLengthString;

            do
            {
                Console.Write("Enter length for the matrix: ");
                matrixLengthString = Console.ReadLine().Trim();
            } 
            while (!int.TryParse(matrixLengthString, out matrixLength));

            var matrix = new int[matrixLength, matrixLength];

            if (matrixType.Equals("a"))
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = row + 1 + (col * matrixLength);
                    }
                }
            }
            else if (matrixType.Equals("b"))
            {
                var currentNumber = 1;
                var maxNumber = matrixLength * matrixLength;
                var row = 0;
                var rowIncrement = 1;
                var col = 0;

                while (true)
                {
                    if (row <= matrixLength - 1 && row >= 0)
                    {
                        if (col <= matrixLength - 1)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                            row += rowIncrement;
                            if (currentNumber > maxNumber)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        col++;
                        rowIncrement *= -1;
                        row += rowIncrement;
                    }
                }
            }

            // Display         
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j].ToString().PadLeft(2));
                }

                Console.WriteLine();
            }
        }
    }
}
