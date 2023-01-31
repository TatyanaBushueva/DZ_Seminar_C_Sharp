// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double CalculationX(double k01, double b01, double k02, double b02)
{
    double x = (b02 - b01) / (k01 - k02);
    return x;
}

double CalculationY(double x, double k01, double b01)
{
    double y = k01 * x + b01;
    return y;
}


if (k1 != k2)
{
    double calculationX = Math.Round(CalculationX(k1, b1, k2, b2), 1);
    double calculationY = Math.Round(CalculationY(calculationX, k1, b1), 1);
    Console.WriteLine($"Точка пересечения двух прямых ({calculationX}, {calculationY})");
}
else Console.WriteLine("Две прямые параллельны");