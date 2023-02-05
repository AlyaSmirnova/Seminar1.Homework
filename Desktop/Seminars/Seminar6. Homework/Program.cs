/* Задача 41.  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPositives(int total)
{
    int count = 0;
    for(int i = 0; i <= total; i++)
    {
        Console.Write("Input a number " + i + ": ");
        if(Convert.ToInt32(Console.ReadLine()) > 0) count++;
    }
    return count;
}

Console.Write("Input amount of numbers: ");
int total = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You entered {CountPositives(total)} positive numbers");
*/

//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k2 * x + b2;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"The lines will cross with the coordinates {x};{y}.");