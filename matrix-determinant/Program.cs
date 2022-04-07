using System;

namespace MatrixDeterminant
{
    class Program
    {
        static int[,] matrix = new int[3, 3];
        static int determinant = 0;

        static void Main(string[] args)
        {
            getMatrixValues();
            createMatrix();
            getTranspose();
            calculateDeterminant();
        }

        static void getMatrixValues()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("value of [{0}],[{1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
        }

        static void createMatrix()
        {
            Console.WriteLine("Generated matrix: \n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void getTranspose()
        {
            Console.WriteLine("Transpose of matrix: \n");

            for (int k = 0; k < 3; k++)
            {
                for (int m = 0; m < 3; m++)
                {
                    Console.Write(" {0} ", matrix[m, k]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void calculateDeterminant()
        {
            for (int i = 0; i < 3; i++)
            {
                determinant += (matrix[0, i] * matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]);
            }
            
            Console.Write("Detarminant: {0}", determinant);
            Console.Read();
        }
    }
}