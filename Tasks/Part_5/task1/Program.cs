// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();

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
// Сумма положительных элементов массива
// int SumPositive(int[] array)
// {
//     int sum = 0;
//     for(int index = 0; index < array.Length; index++)
//     {
//         if(array[index] > 0)
//         {
//             sum += array[index];
//         }
//     }
//     return sum;
// }
// Сумма отрицательных элементов массива
// int SumNegative(int[] array)
// {
//     int sum = 0;
//     for(int index = 0; index < array.Length; index++)
//     {
//         if(array[index] < 0)
//         {
//             sum += array[index];
//         }
//     }
//     return sum;
// }
// Сумма отрицательных и положительных элементов массива в зависимости от переданного параметра по умалчанию 
// вычесляеться сумма положительных
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
int [] array = CreateArray(8, -9, 9);
PrintArray(array);
// int sumPositive = SumPositive(array);
// int sumNegative = SumNegative(array);
int sumPositive = SumArrayElements(array);
int sumNegative = SumArrayElements(array, -1);
System.Console.WriteLine($"Sum of positive array elements {sumPositive} and sum of negative array elements {sumNegative}");