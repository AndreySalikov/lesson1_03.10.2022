// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//  -> 8

Console.Clear();

int[] Fill(int lenght)
{
    int[] array = new int [lenght];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int number = new Random().Next(0,20);
        array [i] = number;
    } 
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i <= array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }

}

PrintArray(Fill(8));