// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
// Замена элементов массива
int[] ChangingArrayElements(int[] array) // ReplacingArrayElements
{
    for(int index = 0; index < array.Length; index++)
    {
        // if(array[index] > 0 || array[index] < 0) //&& и то и то || или то или то
        // {
        //     array[index] *= -1; /* array[index] = array[index] * -1; */
        // }
        array[index] = array[index] * -1;
    }
    return array;
}


int [] array = CreateArray(4, -9, 9);

PrintArray(array);
System.Console.WriteLine();
PrintArray(ChangingArrayElements(array));

