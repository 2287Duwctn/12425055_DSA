using System;

int a = 48, b = 18;
Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");

static int UCLN(int a, int b)
{
    if (a % b == 0) return b;
    return UCLN(b, a % b);
}