// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое неотрицательное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if ((firstNumber >= 0) && (secondNumber >= 0)) Console.WriteLine(AckermanFunction(firstNumber, secondNumber));
else Console.WriteLine("Введены неверные числа");


int AckermanFunction(int firstNum, int secondNum)
{
    if (firstNum == 0) 
    return secondNum + 1;
    else
    if ((firstNum != 0) && (secondNum == 0)) 
    return AckermanFunction(firstNum - 1, 1);
    else 
    return AckermanFunction(firstNum - 1, AckermanFunction(firstNum, secondNum - 1));
}




