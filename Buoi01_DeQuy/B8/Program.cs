using System;

int n = 4;
Console.WriteLine($"S({n}) = {S(n):F4}");

static double Can(int i, int n)
{
    if (i == n) return Math.Sqrt(n);
    return Math.Sqrt(i + Can(i + 1, n));
}

static double S(int n)
{
    return Can(1, n);
}