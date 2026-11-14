using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine(" Bài 1: Tính S(n) = 1 + 2 + ... + n");
Bai1();

Console.WriteLine("\n Bài 2: Tính S(n) = 1^2 + 2^2 + ... + n^2");
Bai2();

Console.WriteLine("\n Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n");
Bai3();

Console.WriteLine("\n Bài 4: Tính S(x, n) = x^n");
Bai4();

Console.WriteLine("\n Bài 5: Tìm ước số lẻ lớn nhất của n");
Bai5();

Console.WriteLine("\n Bài 6: Tìm UCLN của hai số nguyên dương a, b");
Bai6();

Console.WriteLine("\n Bài 7: Đếm số chữ số của số nguyên dương n");
Bai7();

Console.WriteLine("\n Bài 8: Tính tổng căn lồng nhau S(n)");
Bai8();

static void Bai1()
{
    int n = 10;
    Console.WriteLine($"S({n}) = {Tong1(n)}");

    static int Tong1(int n)
    {
        if (n == 1) return 1;
        return Tong1(n - 1) + n;
    }
}

static void Bai2()
{
    int n = 5;
    Console.WriteLine($"S({n}) = {Tong2(n)}");

    static long Tong2(int n)
    {
        if (n == 1) return 1;
        return Tong2(n - 1) + (long)n * n;
    }
}

static void Bai3()
{
    int n = 5;
    Console.WriteLine($"S({n}) = {Tong3(n):F4}");

    static double Tong3(int n)
    {
        if (n == 1) return 1.0;
        return Tong3(n - 1) + 1.0 / n;
    }
}

static void Bai4()
{
    double x = 2.0;
    int n1 = 5, n2 = -2;
    Console.WriteLine($"{x}^{n1} = {S(x, n1)}");
    Console.WriteLine($"{x}^{n2} = {S(x, n2)}");

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
}

static void Bai5()
{
    int n = 100;
    Console.WriteLine($"Ước lẻ lớn nhất của {n} là: {UocLeMax(n)}");

    static int UocLeMax(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeMax(n / 2);
    }
}

static void Bai6()
{
    int a = 48, b = 18;
    Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");

    static int UCLN(int a, int b)
    {
        if (a % b == 0) return b;
        return UCLN(b, a % b);
    }
}

static void Bai7()
{
    int n = 123456;
    Console.WriteLine($"Số chữ số của {n} là: {SoChuSo(n)}");

    static int SoChuSo(int n)
    {
        if (n == 0) return 0;
        return SoChuSo(n / 10) + 1;
    }
}

static void Bai8()
{
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
}
