// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел M: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = new int[count];

CreateArrayCountNumber(array);
int countPositiveNumber = CountPositiveNumber(array);
Console.WriteLine($"Количество введенных чисел больше нуля: {countPositiveNumber}");


int[] CreateArrayCountNumber(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountPositiveNumber(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    return result;
}