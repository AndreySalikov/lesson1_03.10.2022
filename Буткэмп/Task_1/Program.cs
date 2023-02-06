using System.Diagnostics;

// 1 3 4 1 3 4 1 4 1 2
// m = 3
// MAX → 15

int size = 1_000_000;

int m = 30_000;

int[] array = Enumerable.Range(1, size).Select(item => Random.Shared.Next(10)).ToArray();

Stopwatch sw = new();
sw.Start();

int max = 0;
for (int j = 0; j < m; j++) max += array[j];
int t = max;
for (int i = 1; i < array.Length - m; i++)
{
    t = t - array[i - 1] + array[i + (m - 1)];
    if (t > max) max = t;
}
sw.Stop();
System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
System.Console.WriteLine(max);



// Console.WriteLine($"[{string.Join(", ", array)}]");

// Stopwatch sw = new();
// sw.Start();

// int max = 0;
// for (int i = 0; i < array.Length - m; i++)
// {
//     int t = 0;
//     for (int j = i; j < i + m; j++)
//     {
//         t = t + array[j];
//     }
//     if (t > max) max = t;
// }
// sw.Stop();
// System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
// System.Console.WriteLine(max);
