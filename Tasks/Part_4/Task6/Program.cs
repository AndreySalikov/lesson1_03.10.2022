// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача *: Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
// Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

Console.Clear();

// int[] Fill(int lenght)
// {
//     int[] array = new int [lenght];
//     for (int i = 0; i <= array.Length - 1; i++)
//     {
//         int number = new Random().Next(0,11);
//         array [i] = number;
//     } 
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i <= array.Length - 1; i++)
//     {
//         System.Console.Write($"{array[i]}\t ");
//     }
// }

// PrintArray(Fill(10));

int[] array = {-2, -2, -1, -1};

int firstMax = array[0];
int senodMax = array[1];

for(int i = 0; i < array.Length; i++)
{
    if (firstMax < array[i])
    {
        senodMax = firstMax;
        firstMax = array[i];
    }
    else if (senodMax < array[i] && array[i] != firstMax)
    {
        senodMax = array[i];
    }
}
System.Console.Write(firstMax);
System.Console.WriteLine();
System.Console.Write(senodMax);
