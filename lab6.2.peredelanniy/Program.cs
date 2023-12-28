using System;
using MatrixLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        double[,] matrix = new double[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите элемент [{i}, {j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double sum = MatrixOperations.CalculateSumOfMinMax(matrix);

        Console.WriteLine("Сумма максимального и минимального элементов матрицы: " + sum);
    }


}