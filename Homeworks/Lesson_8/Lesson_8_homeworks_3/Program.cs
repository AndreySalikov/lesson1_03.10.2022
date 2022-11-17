// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int m = InputNumbers("Enter the number of rows of the 1st matrix: ");
int n = InputNumbers("Enter the number of columns of the 1st matrix (and rows of the 2nd): ");
int p = InputNumbers("Enter the number of columns of the 2nd matrix: ");
int range = InputNumbers("Enter a range of random numbers: from 1 to ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nFirst Martrix:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nSecomd Martrix:");
WriteArray(secomdMartrix);



Console.WriteLine($"\nProduct of the first and second matrices:");
WriteArray(MultiplyMatrix(firstMartrix, secomdMartrix));

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix)
{
    int[,] resultMatrix = new int[firstMartrix.GetLength(0),secomdMartrix.GetLength(1)];
    for (int i = 0; i < firstMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < secomdMartrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
                {
                    sum += firstMartrix[i,k] * secomdMartrix[k,j];
                    resultMatrix[i,j] = sum;
                }
        }
    }
    return resultMatrix;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}