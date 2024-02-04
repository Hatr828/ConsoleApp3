using System;

class Program
{
    static void Main()
    {
        int N = 3;
        int result = CountStairs(N);

        Console.WriteLine($"Из {N} кубиков можно построить {result} ступеней.");
    }

    static int CountStairs(int N)
    {
        if (N <= 1)
        {
            return N;
        }
        else
        {
            return N + CountStairs(N - 1);
        }
    }
}