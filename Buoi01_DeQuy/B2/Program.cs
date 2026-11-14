using System;

int n = 5;
Console.WriteLine($"S({n}) = {Tong2(n)}");

static long Tong2(int n)
{
    if (n == 1) return 1;
    return Tong2(n - 1) + (long)n * n;
}