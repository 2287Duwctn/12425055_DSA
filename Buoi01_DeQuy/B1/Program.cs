using System;

int n = 10;
Console.WriteLine($"S({n}) = {Tong1(n)}");

static int Tong1(int n)
{
    if (n == 1) return 1;
    return Tong1(n - 1) + n;
}