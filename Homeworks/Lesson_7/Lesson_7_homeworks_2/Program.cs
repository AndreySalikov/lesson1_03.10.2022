// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();


(int, int) PositionNumber(int[,] array, int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == m && j == n) return (i, j);
        }
    }
    return (-1, -1);
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

void PrintArray(int[,] array)
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


int m = Prompt("Enter M ");
int n = Prompt("Enter N ");
System.Console.WriteLine();
int[,] array = CreateArray(m, n);
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int i = Prompt("Enter I ");
int j = Prompt("Enter J ");
System.Console.WriteLine();

(int line, int column) = PositionNumber(array, i, j);
if (line == -1)
{
    System.Console.WriteLine("There not this number");
}
else
{
    System.Console.WriteLine($"({line}, {column})");
}