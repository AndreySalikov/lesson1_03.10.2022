// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 4: 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
    // int [] newArray;
    // if (array.Length % 2 == 0)
    // {
    //     newArray = new int[array.Length / 2];
    // }
    // else
    // {
    //     newArray = new int[array.Length / 2 + 1];
    // }

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
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int arrayLen = Prompt("Enter array length: ");
// int arrayMinIndex = Prompt("Enter array MinIndex: ");
// int arrayMaxIndex  = Prompt("Enter array MaxIndex: ");
int [] array = CreateArray(new Random().Next(3,8), new Random().Next(-9,1), new Random().Next(-1,9));
PrintArray(array);
int [] newArray = ProductOfPairsOfNumbers(array);
PrintArray(newArray);