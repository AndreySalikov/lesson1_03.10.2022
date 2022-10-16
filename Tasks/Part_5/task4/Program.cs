// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
int arrayLen = Prompt("Enter array length: ");
int arrayMinIndex = Prompt("Enter array MinIndex: ");
int arrayMaxIndex  = Prompt("Enter array MaxIndex: ");
int [] array = CreateArray(arrayLen, arrayMinIndex, arrayMaxIndex);
PrintArray(array);
int minNumber = Prompt("Enter min: ");
int maxNumber = Prompt("Enter max: ");
System.Console.WriteLine($"{CountOfArrayElementsBetweenNumbers(array, minNumber, maxNumber)}");