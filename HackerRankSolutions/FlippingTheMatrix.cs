using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class FlippingTheMatrix
    {
        public int flippingMatrix(List<List<int>> matrix)
        {
            int n = matrix.Count / 2; // Size of the matrix (n x n)
            int maxSum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Find the maximum value among the four corresponding elements
                    int topLeft = matrix[i][j];
                    int topRight = matrix[i][2 * n - j - 1];
                    int bottomLeft = matrix[2 * n - i - 1][j];
                    int bottomRight = matrix[2 * n - i - 1][2 * n - j - 1];

                    int maxVal = Math.Max(Math.Max(topLeft, topRight), Math.Max(bottomLeft, bottomRight));
                    maxSum += maxVal;
                }
            }
            return maxSum;
        }
    }
}
