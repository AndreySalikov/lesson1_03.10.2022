﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

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

int[] CreateArrayRandom()
{
    Random rnd = new Random();
    // int lenght = rnd.Next(3, 11);
    int[] array = new int[rnd.Next(3, 11)];
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = rnd.Next(99, 1000);
    }
    return array;
}

void FillArray (int[] collection)
{
    int length = collection.Length; 
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToInt32(new Random(). Next(99, 1000));
        index = index +1; // index++
    }
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

int CountOfArrayElementsBetweenNumbers(int[] array, int minNumber, int maxNumber)
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] >= minNumber && array[index] <= maxNumber)
        {
            count += 1;
        }
    }
    return count;
}

int[] ProductOfPairsOfNumbers(int[] array)
{
    int [] newArray = new int[array.Length / 2 - 1 + array.Length % 2 + 1];

    for(int index = 0; index < array.Length / 2; index++)
    {
        newArray[index] = array[index] * array[array.Length -1 -index];
    }

    if(array.Length % 2 != 0)
    {
        newArray[newArray.Length - 1] = array[newArray.Length - 1];
    }
    return newArray;
}

int CountOfEvenArrayElements(int[] array)
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int CountOfArrayElements(int[] array)
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
    {
        count += 1;
    }
    return count;
}

int SumOfArrayElements(int[] array)
{
    int sum = 0;
    for(int index = 0; index < array.Length; index++)
    {
        sum += array[index];
    }
    return sum;
}
int SumOfOddArrayElements(int[] array)
{
    int sum = 0;
    for(int index = 0; index < array.Length; index++)
    {
       if(index % 2 == 0)
       {
            sum += array[index];
        }
    }
    return sum;
}

// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

int [] array = CreateArrayRandom();
System.Console.Write($"Your random array: ");
PrintArray(array);
System.Console.WriteLine($"Count of all array elements {CountOfArrayElements(array)}");
System.Console.WriteLine($"Sum of all array elements {SumOfArrayElements(array)}");
System.Console.WriteLine($"Sum of all odd array elements {SumOfOddArrayElements(array)}");