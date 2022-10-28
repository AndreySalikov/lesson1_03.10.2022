// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 5: * Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

Console.Clear();

int SumMax(int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max = array[0, i];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(max < array[i, j])
            {
                max = array[i,j];
            }
        }
        sum += max;
    }
    return sum;
}

int SumMin(int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int min = array[0,i];
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if(min > array[j, i]) min = array[j,i];
        }
        sum += min;
    }
    return sum;
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
int[,] array = CreateArray(m, n);
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Max ");
System.Console.WriteLine(SumMax(array));
System.Console.Write("Min ");
System.Console.WriteLine(SumMin(array));
System.Console.WriteLine();
System.Console.WriteLine(SumMax(array) - SumMin(array));