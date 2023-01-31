// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

int[,] array2D = CreateMatrixRndInt(5, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
Console.WriteLine("Введите номер строки: ");
int numberRows = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите номер столбца: ");
int numberColums = Convert.ToInt32(Console.ReadLine()) - 1;

if (FindElement(array2D, numberRows, numberColums)) Console.WriteLine($"Значение элемента в массиве: {array2D[numberRows, numberColums]}");
else
    Console.WriteLine("Такого элемента в массиве не существует");



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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}


bool FindElement(int[,] matrix, int rows, int colums)
{
    bool result = false;
    if (rows >= 0 && rows < matrix.GetLength(0) && colums >= 0 && colums < matrix.GetLength(1)) result = true;
    else
        result = false;
    return result;
}



