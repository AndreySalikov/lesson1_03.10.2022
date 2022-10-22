// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 4: Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.
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

int[] CopyArray(int [] array)
{
    int[] array_copy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        array_copy[i] = array[i];
    }
    return array_copy;
}

int [] array = CreateArray();
FillArray(array);
int [] arrayCopy = array;
int [] array2 = CopyArray(array);
array[0] = -1;
PrintArray(array);
PrintArray(arrayCopy);
PrintArray(array2);

