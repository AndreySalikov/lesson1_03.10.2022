// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

int InputPoint(string message) // Ввод числа по приглашению
{
    Console.Write(message); // Вывод приглашения \ сообщения
    string str = Console.ReadLine(); //Читаем строку из консоли
    return Convert.ToInt32(str); // Преобразуем строку в число
    //return Convert.ToInt32(Console.ReadLine()); //Читаем строку из консоли и Преобразуем строку в число
    //return Int16.Parse(str) // Преобразуем строку в число
}
// Сумма чисел от 1 до Number (Параметр)
int SumNumbers(int number)
{
    int sum = 0; // тут накапливаем сумму
    for (int i = 1; i <= number; i++) // цикл от одного до параметра
    {
        //sum = sum + i; // сумируем
        sum += i;
    }
    return sum; // возвращаем сумму
}
// Проверка на правильность ввода
bool ValidateNumber(int number)
{
    if (number < 1) // при чесле меньше 1 не работаем
    {
        System.Console.WriteLine("Number < 1");
        return false;
    }
    return true;
}

int number = InputPoint("Enter number: ");
if (ValidateNumber(number))
{
    int result = SumNumbers(number);
    System.Console.WriteLine($"Sum numbers to 1 for {number} = {result}");
}