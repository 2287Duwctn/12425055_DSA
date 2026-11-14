using System;

double x = 2.0;
int n = 5;
Console.WriteLine($"{x}^{n} = {S(x, n)}");

static double LuyThua(double X, int N)
{
    if (N == 0) return 1;
    return LuyThua(X, N - 1) * X;
}

static double S(double x, int n)
{
    if (n < 0) return 1.0 / LuyThua(x, -n);
    return LuyThua(x, n);
}