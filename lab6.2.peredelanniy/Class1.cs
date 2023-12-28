using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2.peredelanniy
{
    internal class Class1
    {
    }
}
namespace MatrixLibrary
{
    public class MatrixOperations
    {
        public static double CalculateSumOfMinMax(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            double min = matrix[0, 0];
            double max = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];

                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
            }
            double sum = min + max;

            return sum;
        }
    }
}