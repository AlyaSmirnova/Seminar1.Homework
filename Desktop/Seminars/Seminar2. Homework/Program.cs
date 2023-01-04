/* Задача 10. Напишите прграмму, которая на вход принимает трёхзначное число и на выходе показывает вторую цирфу этого числа.

int func(int number)
{
    int ed = number / 10;
    int result = ed % 10;
    return result;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    Console.WriteLine(func(number));
}
else
{
    Console.WriteLine("This number is incorrect");
}
*/

/* Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

int ThirdDigit(int number)
{
    while (number >= 1000)
        number = number / 10;
        int result = number % 10;
        return result;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine($"Third digit in number {number} does not exist");
}
else
{
    Console.WriteLine(ThirdDigit(number));
}
*/

/* Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend (int number)
{
    if ((number == 6) || (number == 7)) return true;
    else return false;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Weekend(number));
*/