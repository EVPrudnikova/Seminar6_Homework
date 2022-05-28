/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

double k1 = Number("k1");
double b1 = Number("b1");
double k2 = Number("k2");
double b2 = Number("b2");

if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = CountX(k1, b1, k2, b2);
    double y = CountY(k1, b1, k2, b2);
    Console.WriteLine($"Координаты пересечения прямых: ({x}; {y})");
}

double CountX(double a1, double a2, double c1, double c2)
{
    return(c2 - a2) / (a1 - c1);
}

double CountY(double a1, double a2, double c1, double c2)
{
    return a1 * ((c2 - a2) / (a1 - c1)) + a2;
}

int Number(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
