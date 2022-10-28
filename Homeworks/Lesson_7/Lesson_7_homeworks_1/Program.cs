// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int Prompt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    return array;
}

void FillArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
}

void PrdoubleArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2}\t");
        }
    System.Console.WriteLine();
    }
}

int m = Prompt("Enter M ");
int n = Prompt("Enter N ");
double[,] array = CreateArray(m, n);
FillArray(array);
PrdoubleArray(array);