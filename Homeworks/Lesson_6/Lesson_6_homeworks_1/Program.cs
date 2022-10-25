// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  Задача 1: Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int Prompt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int message)
{
    int[] array = new int[message];
    return array;
}

void FillArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Enter the {i+1}-th number -> ");
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


int CountOfArrayElements(int[] array)
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index]>0) 
        {
            count += 1;
        }
    }
    return count;
}

int [] array = CreateArray(Prompt("How many numbers? "));
FillArray(array);
PrintArray(array);
System.Console.WriteLine($"You entered {CountOfArrayElements(array)} numbers greater than 0");
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3