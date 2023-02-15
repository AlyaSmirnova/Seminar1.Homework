/* Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void CreateRandomArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void SortToLower(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if(array[i,m] < array[i, m + 1])
                {
                    int temp = array[i, m + 1];
                    array[i, m + 1] = array[i, m];
                    array[i, m] = temp;
                }
            }
        }
    }
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] newArray = new int[3, 4];
CreateRandomArray(newArray);
ShowArray(newArray);
SortToLower(newArray);
Console.WriteLine();
ShowArray(newArray);


// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void SearchSmallestSum(int[,] array)
{
    int minString = 0; 
    int minSumString = 0;
    int sumString = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) sumString += array[i, j];
        if(sumString < minString)
        {
            minString = sumString;
            minSumString = i;
        }
        sumString = 0;
    }
    Console.Write($"{minSumString + 1} the string with the smallest sum of elements.");
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CreateRandomArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

int[,] newArray = new int[4, 4];
CreateRandomArray(newArray);
ShowArray(newArray);
Console.WriteLine();
SearchSmallestSum(newArray);


// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = ReadInt("Input a number of rows: ");
int columns = ReadInt("Input a number of columns: ");
int[,] array = new int[rows, columns];
int[,] newArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

CreateRandomArray(array);
ShowArray(array);
Console.WriteLine();

CreateRandomArray(newArray);
ShowArray(newArray);
Console.WriteLine();

void CreateRandomArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

if(array.GetLength(0) != newArray.GetLength(1))
{
    Console.WriteLine("Input error: the number of columns in the first matrix should be equal to the number of rows in the second matrix.");
    return;
}
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < newArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for(int m = 0; m < array.GetLength(1); m++)
        {
            resultArray[i, j] += array[i, m] * newArray[m, j];
        }
    }
}

ShowArray(resultArray);

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = new int[2, 2, 2];

void ShowIndex(int[,,] newArray)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for(int m = 0; m < array.GetLength(2); m++)
            {
                Console.Write($"{array[i, j, m]}({i}, {j}, {m}) ");
            }
        }
    }
}

void CreateArray(int[,,] newArray)
{
    int count = 10;
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            for(int m = 0; m < newArray.GetLength(2); m++)
            {
                newArray[m, i, j] += count;
                count += 3;
            }
        }
    }
}

CreateArray(array);
ShowIndex(array);
Console.WriteLine();
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = new int[4, 4];

void CreateSpiralArray(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for(int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n -1);
        for(k = 0; k < n - 1; k++) array[i++, j] = value++;
        for(k = 0; k < n - 1; k++) array[i, j--] = value++;
        for(k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

CreateSpiralArray(array, 4);
ShowArray(array);