// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9



Console.WriteLine("Введите количество строк двумерного массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > 0 && n > 0)
{
    double[,] array2D = CreateMatrixRndDouble(m, n, 1, 10);
    PrintMatrix(array2D);
    Console.WriteLine();
}
else
    Console.WriteLine("Количество строк и столбцов двумерного массива введено некорректно");



double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine(" ");
    }
}




