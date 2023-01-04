/* Задача 19. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом. 

bool Palindrome(int number)
{
    int result = 0;
    int newNumber = number;
    while (number > 0)
    {
        result = result * 10 + number % 10;
        number = number / 10;
    }
    return result == newNumber;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Palindrome(number))
Console.WriteLine($"The number {number} is a palindrome");
else Console.WriteLine($"The number {number} is not a palindrome");
*/

/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D-пространстве. 

double Func(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2,2));
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Func(x1,y1,z1,x2,y2,z2));
*/

/* Задача 23. Напишите прграмму, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

void Func(int n)
{
    int count = 1;
    while (count <= n)
    {
        int x = count * count * count;
        Console.WriteLine($"{count} to {x}");
        count++;
    }
}

Console.Write("Input n: ");
int newN = Convert.ToInt32(Console.ReadLine());

Func(newN);
*/