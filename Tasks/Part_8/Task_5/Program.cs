// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 5: 
/*Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника.
*/

Console.Clear();
///Вывод треугольника Паскаля двумерным массивом:
///минус в лишних нулях((

// Console.WriteLine("Введите количество строк треугольника Паскаля:");
// int numberRows = int.Parse(Console.ReadLine());

// ///Метод заполнения массива алгоритмом Паскаля:
// int [,] FillPascalArray (int numberRows)
// {
//     int rows = numberRows;
//     int columns = numberRows + 2;
//     int [,] array = new int [rows, columns];
//     array[0, 0 ] = 0;
//     array[0, 1 ] = 1;
//     array[0, 2 ] = 0;
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         for (int j = 1; j < array.GetLength(1); j++)
//         {
//             array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
//         }
//     }
//     return array;
// }


// ///Метод печати массива Паскаля:
// void PrintPascalArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int k = array.GetLength(0); k > i; k--)
//             {
//                 Console.Write("  ");
//             }
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write("{0,4}", array[i, j]);
//             }
//         Console.WriteLine();
//     }
// }

// int [,] array =  FillPascalArray(numberRows);
// Console.WriteLine();

// PrintPascalArray(array);

// int i, n, c;
// Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
// string s = Console.ReadLine();
// n = Convert.ToInt32(s);

// float factorial(int n)
//         {
//             float i, x = 1;
//             for (i = 1; i <= n; i++)
//             {
//                 x *= i;
//             }
//             return x;
//         }

// for (i = 0; i < n; i++)
//             {
//                 for (c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
//                 {
//                     Console.Write(" "); 
//                 }
//                 for (c = 0; c <= i; c++)
//                 {
//                     Console.Write(" "); // создаём пробелы между элементами треугольника
//                     Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
//                 }
//                 Console.WriteLine();
//                 Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
//             }
//             Console.ReadLine();


int row = 128;
int[,] triangle = new int[row, row];
// const int cellWidth = 3;
const int cellWidth = 1;
void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if(triangle[i, j] != 0) 
            System.Console.Write($"{triangle[i, j], cellWidth}");
        }
        System.Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            // if(triangle[i, j] != 0) System.Console.Write($"{triangle[i, j], cellWidth}");
            // if(triangle[i, j] != 0) System.Console.WriteLine("*");
            if(triangle[i, j] % 2 != 0) System.Console.Write("*");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        System.Console.WriteLine();
    }
}
 

Console.ReadLine();
FillTriangle();
// PrintTriangle();
Magic();