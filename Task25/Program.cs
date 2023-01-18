// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Ведите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0)
{
    int degreeNumber = DegreeNumber(numberA, numberB);
    Console.WriteLine($"{numberA} в степени {numberB} = {degreeNumber}");
}
else Console.WriteLine("Введеное число B не является натуральным");

int DegreeNumber(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        {
            result = result * num1;
        }
    }
    return result;
}
