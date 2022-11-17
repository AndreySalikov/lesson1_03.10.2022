// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

bool ValidateMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        return true;
    }
    return false; 
} 

int[,] TranspositionMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        for (int i = j; i < matrix.GetLength(0); i++)
            {
                int number = matrix[i,j];
                matrix[i,j] = matrix[j,i];
                matrix[j,i] = number;
            }
        }
    return matrix;
}

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
if (ValidateMatrix(matrix))
{
    PrintMatrix(
        TranspositionMatrix(matrix)
        );
}
else
{
    System.Console.WriteLine("Error, Matrix");
}