// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




int[,] array2D1 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(array2D1);
Console.WriteLine();
int[,] array2D2 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(array2D2);
Console.WriteLine();

if (array2D1.GetLength(1) == array2D2.GetLength(0))
{
    int[,] resultArray2D = MultiplicationMatrix(array2D1, array2D2);
    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(resultArray2D);
    Console.WriteLine();
}
else Console.WriteLine("Вычислить произведение данных матриц невозможно");


int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int colums = matrix2.GetLength(1);
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix[i, j] = matrix[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine(" ");
    }
}
