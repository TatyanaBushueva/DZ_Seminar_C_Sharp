// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
if ((number > 9999) && (number < 100000))
{
    Console.WriteLine(PalindromeNumber(number) == number ? "да" : "нет");
}
else System.Console.WriteLine("Введеное число не является пятизначным");

int PalindromeNumber(int num)
{
    int revers = 0;
    while (num > 0)
    {
        revers = revers * 10 + num % 10;
        num = num / 10;
    }
    return revers;
}







