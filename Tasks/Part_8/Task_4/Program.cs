// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Clear();

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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


(int, int) FindMin(int[,] matrix)
{
    int indRow = 0;
    int indCol = 0;
    
    for (int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[indRow, indCol])
            {
                indRow = i;
                indCol = j;
            }            
        }
    }
    return (indRow, indCol);
}

int[,] ChangeMatrix(int[,] matrix)
{
    int[,] ans = new int[matrix.GetLength(0) - 1,matrix.GetLength(1) - 1];
    (int minRow, int minCol) = FindMin(matrix);
    int a = 0;
    int b = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i != minRow)
        {
            b = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i == minRow || j == minCol)
                {

                }
                else
                {
                    ans[a,b] = matrix[i,j];
                    b++;
                }
            }
            a++;
        }
    }
    return ans;
}

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


int[,] matrix = CreateMatrix(4, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(ChangeMatrix(matrix));

