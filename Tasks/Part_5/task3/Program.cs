// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

int Prompt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = rnd.Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        System.Console.Write($"{array[index]}\t");
    }
    System.Console.WriteLine();
}

int SumArrayElements(int[] array, int fl = 1)
{
    int sum = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] * fl > 0)
        {
            sum += array[index];
        }
    }
    return sum;
}

int[] ChangingArrayElements(int[] array) // ReplacingArrayElements
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = array[index] * -1;
    }
    return array;
}

bool SpecifedNumber(int[] array, int number)
{
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] == number)
        {
            return true;
        }
    }
    return false;
}


int [] array = CreateArray(4, -9, 9);
PrintArray(array);
int number = Prompt("Enter number: ");
System.Console.WriteLine(SpecifedNumber(array, number));

