using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main()
        {
            // Define first matrix
            List<List<int>> matrixA = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 }
            };

            // Define second matrix
            List<List<int>> matrixB = new List<List<int>>
            {
                new List<int> { 7, 8 },
                new List<int> { 9, 10 },
                new List<int> { 11, 12 }
            };

            // Perform multiplication
            List<List<int>> result = Multiply(matrixA, matrixB);

            // Display result
            if (result != null)
            {
                Console.WriteLine("Resultant Matrix:");
                DisplayMatrix(result);
            }
            else
            {
                Console.WriteLine("Matrix multiplication is not possible with the given dimensions.");
            }
        }

        static List<List<int>> Multiply(List<List<int>> matrixA, List<List<int>> matrixB)
        {
            int rowsA = matrixA.Count;
            int colsA = matrixA[0].Count;
            int rowsB = matrixB.Count;
            int colsB = matrixB[0].Count;

            // Check if multiplication is possible
            if (colsA != rowsB)
            {
                return null; // Return null if dimensions are incompatible
            }

            // Initialize result matrix with zeros
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < rowsA; i++)
            {
                result.Add(new List<int>(new int[colsB]));
            }

            // Perform matrix multiplication
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += matrixA[i][k] * matrixB[k][j];
                    }
                    result[i][j] = sum;
                }
            }

            return result;
        }

        static void DisplayMatrix(List<List<int>> matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var element in row)
                {
                    Console.Write(element + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}