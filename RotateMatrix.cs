using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class RotateMatrix
    {
        public void Run()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 22, 33 } };

            Rotate_Matrix(matrix);
        }
        public static void Rotate_Matrix(int[,] matrix)
        {
            int row_length = matrix.GetLength(0);
            int col_length = matrix.GetLength(1);
            //printing original matrix
            Console.WriteLine("Original Matrix");
            for (int i = 0; i < row_length; i++)
            {
                for (int j = 0; j < col_length; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] result_matrix = new int[col_length, row_length];
            int ptr = 0;
            int row_ptr = 0;
            for (int cnt = 0; cnt < col_length; cnt++)
            {
                for (int i = row_length - 1; i >= 0; i--)
                {
                    result_matrix[row_ptr, ptr++] = matrix[i, cnt];

                }
                ptr = 0;
                row_ptr++;
            }
            Console.WriteLine("Rotated Matrix");
            for (int i = 0; i < col_length; i++)
            {
                for (int j = 0; j < row_length; j++)
                {
                    Console.Write(result_matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
