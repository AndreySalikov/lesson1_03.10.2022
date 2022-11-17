// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

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


int SumLines(int[,] matrix, int line)
{
    int sumLine = 0;    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   
        sumLine = sumLine + matrix[line,j];
    }
    return sumLine;
}

int MinSumLinesMatrix(int[,] matrix)
{
    int minSum = SumLines(matrix,0);
    int line = 0; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        if (SumLines(matrix,i) < minSum)
        {    
            minSum = SumLines(matrix,i);
            line = i;
        }
    }
    return line;
}

System.Console.WriteLine();
int lines = Prompt("Find out the size of the matrix. Enter number of lines > ");
int columns = Prompt("Find out the size of the matrix. Enter number of columns > ");
int minLimit = Prompt("We fill in the matrix. Enter minimum limit > ");
int maxLimit = Prompt("We fill in the matrix. Enter the maximum limit > ");
int[,] matrix = CreateMatrix(lines, columns,minLimit, maxLimit);
System.Console.WriteLine("Your matrix ");
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine(MinSumLinesMatrix(matrix));
