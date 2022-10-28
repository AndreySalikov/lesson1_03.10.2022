// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void AverageSum(int [,] array)
{
    double [] sum = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum[i] = 0;
        double count = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[j, i];
            count ++;
            
        }
        System.Console.Write($"{(sum[i]/count):F2}\t");
    }
}

int Prompt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

void FillArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMartix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    System.Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int m = Prompt("Enter M ");
int n = Prompt("Enter N ");
int[,] array = CreateArray(m, n);
FillArray(array);
System.Console.WriteLine();
PrintMartix(array);
System.Console.WriteLine();
AverageSum(array);
