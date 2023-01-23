/* Задача 25. Напишите цикл, который принимает на вход 2 числа (A и B) и возводит число A в натуральную степень B.

int Multiplication(int numA, int numB)
{
    int number = 1;
    for(int i = 1; i <= numB; i++)
    {
        number = number * numA;
    }
    return number;
}

Console.Write("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int mult = Multiplication(numA, numB);
Console.WriteLine(mult);
*/

/* Задача 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

int SumNumber(int num)
{
    int sum;

    for (sum = 0; num != 0; sum += num % 10)
    
        num = num / 10;    
    return sum; 
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int answer = SumNumber(number);
Console.WriteLine(answer);
*/

/* Задача 29. Напишите программу, которая задает массив из m элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(length);
ShowArray(newArray);
*/