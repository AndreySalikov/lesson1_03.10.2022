// Степень двойки

bool IsBinary(int n)
{
    return ((n - 1) & n) == 0;
}

int n = 4096;

System.Console.Write(IsBinary(n));