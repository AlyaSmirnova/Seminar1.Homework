// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Max number is " + num1);
    Console.WriteLine("Min number is " + num2);
}
else
{
    Console.WriteLine("Max number is " + num2);
    Console.WriteLine("Min number is " + num1);
}
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;


if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
    Console.WriteLine("Max number is " + max);
}
else
{
    Console.WriteLine("Max number is " + max);
}
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("The number " + num + " is even");
}
else 
{
    Console.WriteLine("The number " + num + " is uneven");
}
*/

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;

if(number <= 1)
{
    Console.WriteLine("There are no even numbers");
}
else
    while(current <= number)
    {
        if(current % 2 == 0)
        {
            Console.WriteLine(current + "");
            current = current + 2;
        }
        else
        {
            current = current + 1;
        }
    }
*/