// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Ведите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int sumNumber = SumNumber(number);
    Console.WriteLine($"Сумма цифр в числе {number} = {sumNumber}");
}
else Console.WriteLine("Введено некоректное число");

int SumNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

