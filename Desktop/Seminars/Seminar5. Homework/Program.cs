/* Задача 34. Задайте массив, заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        return array;
    }
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

int CountEven (int[] array)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count ++;
    return count;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length);
ShowArray (array);
Console.WriteLine($"In this array we have: {CountEven(array)} even elements");
*/
/* Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях. 

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        return array;
    }
}

void ShowArray(int[] array, char symb)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i!= array.Length - 1)
        {
            if (i % 2 != 0) Console.Write($"{symb}{array[i]}");
            else Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine();
}

int SumArray(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if (i % 2 != 0) sum = sum + array[i];
    return sum;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a possible min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a possible max value: ");
int max = Convert.ToInt32(Console.ReadLine());
ShowArray(array, '_');
Console.WriteLine(Array.MaxLength > 1? $"In this array we have sum of odd element = {SumArray(array)}" : "Array has only one element");
*/ 