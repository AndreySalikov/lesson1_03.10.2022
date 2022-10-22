// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Clear();

int Prompt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        System.Console.Write($"{array[index]}\t");
    }
    System.Console.WriteLine();
}

int [] Binarny(int number)
{
    int[] array = new int[10];
    int count = array.Length - 1;
    while (number > 0)
    {
        array[count] = number % 2;
        number /= 2;
        count--;
    }
    return array;
}

int number = Prompt("Введите число: ");
int [] array = Binarny(number);
PrintArray(array);