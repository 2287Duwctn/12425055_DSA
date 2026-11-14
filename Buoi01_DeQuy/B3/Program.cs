using System;

int n = 5;
Console.WriteLine($"S({n}) = {Tong3(n):F4}");

static double Tong3(int n)
{
    if (n == 1) return 1.0;
    return Tong3(n - 1) + 1.0 / n;
}