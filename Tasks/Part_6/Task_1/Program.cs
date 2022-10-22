// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


Console.Clear();

int[] CreateArray()
{
    Random rnd = new Random();
    int [] array = new int [rnd.Next(3, 10)];
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


int [] array = CreateArray();
FillArray(array);
PrintArray(array);
Reverse(array);
PrintArray(array);