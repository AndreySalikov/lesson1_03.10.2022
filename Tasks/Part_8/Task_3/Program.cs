// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9
//  Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

Console.Clear();

int[] CreateArray(int m, int minLimit, int maxLimit)
{
    int[] array = new int[m];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
            array[i] = rnd.Next(minLimit, maxLimit);
    }
    return array;
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
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

bool ValidateMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        return true;
    }
    return false; 
} 

int[] DictionaryArray(int[,] matrix)
{
    int[] dict = new int[10];
    for (int i = 0; i < dict.Length; i++)
    {
        int count = 0;
        foreach (var item in matrix)
        {
            if(item == i)
            {
                count++;
            }
            dict[i] = count;
        }
    }
    return dict;
}

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] DictionaryArrayNew(int[,] matrix)
{
    int[] dict = new int[10];
    foreach (var item in matrix)
    {
        dict[item]++;
    }
    return dict;
}

System.Console.WriteLine();
int m = Prompt("Find out the size of the matrix. Enter number of lines > ");
int n = Prompt("Find out the size of the matrix. Enter number of columns > ");
int minLimit = Prompt("We fill in the matrix. Enter minimum limit > ");
int maxLimit = Prompt("We fill in the matrix. Enter the maximum limit > ");
int[,] matrix = CreateMatrix(m, n,minLimit, maxLimit);
System.Console.WriteLine("Your matrix ");
PrintMatrix(matrix);
System.Console.WriteLine();
int[] dict = DictionaryArray(matrix);
PrintArray(dict);
System.Console.WriteLine();
int[] dict1 = DictionaryArrayNew(matrix);
PrintArray(dict1);