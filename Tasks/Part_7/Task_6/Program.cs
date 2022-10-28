// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// найти минимум в масиве

Console.Clear();

int Min(int[,] array)
{
    int min = array[0, 0];
    foreach ( int item in array) // foreach просматривает все элементы по порядку
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
}

int Min2(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        if (array[i, j] < min)
        {
            min = array[i, j];
        }
    }
    return min;
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
int min = Min(array);
System.Console.WriteLine(min);
System.Console.WriteLine();
int min2 = Min2(array);
System.Console.WriteLine(min2);