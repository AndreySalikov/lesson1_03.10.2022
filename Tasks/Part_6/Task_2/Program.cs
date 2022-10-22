// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();

int[] CreateArray()
{
    int [] array = new int [3];
    return array;
}

void FillArray(int [] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] Reverse(int [] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array [i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

bool CheckTriangle(int [] array)
{
    if(array[0] + array[1] < array[2]) return false;
    if(array[0] + array[2] < array[1]) return false;
    if(array[2] + array[1] < array[0]) return false;
    return true;
}

int [] array = CreateArray();
FillArray(array);
PrintArray(array);
System.Console.WriteLine(CheckTriangle(array));