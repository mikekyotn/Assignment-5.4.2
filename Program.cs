using System.Drawing;

namespace Assignment_5._4._2
{
    //Find the sum of a the right diagonals of a matrix
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of the squre matrix: ");
            uint matrixSize = GetMatrixSize();
            double[,] matrix = PopulateMatrix(matrixSize);
            PrintMatrix(matrix);
            Console.WriteLine($"Addition of hte right Diagonal elements is: {AddDiagonals(matrix, matrixSize)}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static double AddDiagonals(double[,] matrix, uint size)
        {
            int i = 0;
            double sum = 0;
            while (i < size)
            {
                sum += matrix[i, i];
                i++;
            }
            return sum;
        }
        static uint GetMatrixSize()
        {
            uint userInput = 0;            
            while (!UInt32.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("Invalid entry, please enter a positive integer: ");
            }
            return userInput;
        }
        static double GetCellInput()
        {
            double userInput = 0;
            while (!Double.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("Invalid entry, please enter a number: ");
            }
            return userInput;
        }
        static double[,] PopulateMatrix(uint size)
        {
            double[,] matrix = new double[size, size];
            Console.WriteLine("Input elements for the matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"element - [{i}][{j}]: ");
                    matrix[i, j] = GetCellInput();
                }
            }
            Console.WriteLine();
            return matrix;
        }
        static void PrintMatrix(double[,] matrix)
        {
            Console.WriteLine("Your matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write($"{matrix[i,j]} ");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
