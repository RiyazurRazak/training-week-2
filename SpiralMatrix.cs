using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class SpiralMatrix
    {

        public int[] Traverse(int[,] matrix, int[] output, int idx=0)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            if (row == 0 || col == 0)
            {
                return output;
            }
            if(row == 1)
            {
                for(int i=0; i<col; i++)
                {
                    output[idx++] = matrix[0,i];
                }
                return output;
            }
            else
            {
               
                for (int i = 0; i < col; i++)
                {
                    output[idx++] = matrix[0, i];
                }
                for (int i = 1; i < row; i++)
                {
                    output[idx++] = matrix[i, col - 1];

                }
                for (int i = col - 2; i >= 0; i--)
                {
                    output[idx++] = matrix[row - 1, i];
                }
                int[,] newMatrix = new int[row - 2, col - 1];

                for (int i = 1; i <= row - 2; i++)
                {
                    for (int j = 0; j < col - 1; j++)
                    {
                        newMatrix[i - 1, j] = matrix[i, j];
                    }
                }

                Traverse(newMatrix, output, idx);

                return output;
            }
        }
        public void Run()
        {
            int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[] output = new int[matrix.GetLength(0) * matrix.GetLength(1)];
            int [] answer = Traverse(matrix, output);
            foreach(int n in answer)
            {
                Console.Write(n + " ");
            }

        }

    }
}

