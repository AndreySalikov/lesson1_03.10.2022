// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

Console.Clear();

(int, int) Search(int [,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == number)
            {
                return (i, j);
            }
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
            array[i, j] = new Random().Next(1, 20);
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
System.Console.WriteLine();
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int number = Prompt("Enter number -> ");
System.Console.WriteLine();
System.Console.WriteLine(Search(array, number));
System.Console.WriteLine();
(int line, int column) = Search(array,number);
if (line == -1)
{
    System.Console.WriteLine("There not this number");
}
else
{
    System.Console.WriteLine($"({line}, {column})");
}