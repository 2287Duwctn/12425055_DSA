using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int n = 100;
Console.WriteLine($"Ước lẻ lớn nhất của {n} là: {UocLeMax(n)}");

static int UocLeMax(int n)
{
    if (n % 2 == 1) return n;
    return UocLeMax(n / 2);
}