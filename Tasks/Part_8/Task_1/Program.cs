// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.


Console.Clear();

int[,] CreateMatrix(int m, int n, int minLimit, int maxLimit)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minLimit, maxLimit);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
    System.Console.WriteLine();
    }
}

int[,] ChangeMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int number = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = number;
    }
    return matrix;
}

// PrintMatrix(
//     CreateMatrix(4, 4, 10, 20));
// System.Console.WriteLine();
// PrintMatrix(
//     ChangeMatrix(
//             CreateMatrix(4, 4, 10, 20)
//     )
// );    

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
System.Console.WriteLine();
int m = Prompt("Find out the size of the matrix. Enter number of lines > ");
int n = Prompt("Find out the size of the matrix. Enter number of columns > ");
int minLimit = Prompt("We fill in the matrix. Enter minimum limit > ");
int maxLimit = Prompt("We fill in the matrix. Enter the maximum limit > ");
int[,] matrix = CreateMatrix(m, n,minLimit, maxLimit);
System.Console.WriteLine("Your matrix ");
PrintMatrix(matrix);
System.Console.WriteLine("Your new matrix");
PrintMatrix(
        ChangeMatrix(matrix)
);