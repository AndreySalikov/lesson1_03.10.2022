// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

int Prompt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray()
{
    int[] array = new int[4];
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


bool ValidateQuartet(int[] array)
{
    if (array[0] == array[2])
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
    else if (array[1] == array[3])
    {
        Console.WriteLine($"Пересекаються в точке (0; {array[1]})");
        return false;
    }
    return true;
}


int [] array = CreateArray();
FillArray(array);
PrintArray(array);

if (ValidateQuartet(array))
{
    int k1 = array[0];   //Первый угловой коэффицент
    int b1 = array[1];   //Первый свободный член
    int k2 = array[2];   //Второй угловой коэффицент
    int b2 = array[3];   //Второй свободный член
    double x = (b2 - b1)/(k1- k2);
    double y = k1 * x + b1;
    System.Console.WriteLine($"Точка пересечения ({x:F1}; {y:F1})");
    return;
}




