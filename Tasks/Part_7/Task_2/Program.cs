﻿// Задача 1: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//  Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

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
            array[i, j] = i + j;
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
int[,] array = CreateArray(m, n);
FillArray(array);
PrintArray(array);