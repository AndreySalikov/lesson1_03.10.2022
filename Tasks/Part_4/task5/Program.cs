// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

int[] Fill(int lenght)
{
    int[] array = new int [lenght];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int number = new Random().Next(0,2);
        array [i] = number;
    } 
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i <= array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}\t ");
    }
}

PrintArray(Fill(8));
