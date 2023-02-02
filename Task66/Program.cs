// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if ((firstNumber > 0) && (secondNumber > 0)) Console.WriteLine(NaturalNumbersSum(firstNumber, secondNumber));
else 
if ((firstNumber <= 0) && (secondNumber > 0))
Console.WriteLine(NaturalNumbersSum(1, secondNumber));
else 
if ((firstNumber > 0) && (secondNumber <= 0))
Console.WriteLine(NaturalNumbersSum(firstNumber, 1));



//Console.WriteLine("В промежутке от M до N натуральных чисел нет");

int NaturalNumbersSum(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return firstNum;
    if (firstNum < secondNum) return firstNum + NaturalNumbersSum(firstNum + 1, secondNum);
    if (firstNum > secondNum) return firstNum + NaturalNumbersSum(firstNum - 1, secondNum);
    return firstNum;
}








