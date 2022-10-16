// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача *: Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5

Console.Clear();

int[] Fill(int lenght)
{
    int[] array = new int [lenght];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int number = new Random().Next(0,100);
        array [i] = number;
    } 
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i <= array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }

}

int MaxNumberArray(int[] array)
{
int firstMax = array[0];
int senodMax = array[1];
    for(int i = 0; i < array.Length; i++)
    {
        if (firstMax < array[i])
        {
            senodMax = firstMax;
            firstMax = array[i];
        }
        else if (senodMax < array[i] && array[i] != firstMax || firstMax == senodMax)
        {
            senodMax = array[i];
        }
    }
    return senodMax;
}

int[] array = Fill(10);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Second max number {MaxNumberArray(array)}");