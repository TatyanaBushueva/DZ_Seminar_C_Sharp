// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

System.Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
if (number > 0)
{
    TableCube(number);
}
else System.Console.WriteLine("Введеное число не является натуральным");

void TableCube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,2} {"|"} {Math.Pow(count, 3)}");
        count++;
    }
}

