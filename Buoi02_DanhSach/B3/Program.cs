using System;
using System.Text;
class B3
{
    static int[,] NhapMaTran(out int n)
    {
        do
        {
            Console.Write("Nhập cấp ma trận vuông n (0 < n < 100): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n >= 100);

        int[,] a = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return a;
    }
    static void InMaTran(int[,] a, int n)
    {
        Console.WriteLine("\nMa trận vừa nhập:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{a[i, j],6}");
            }
            Console.WriteLine();
        }
    }
    static int TongMaTran(int[,] a, int n)
    {
        int t = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                t += a[i, j];
            }
        }
        return t;
    }
    static int DuongNhoNhat(int[,] a, int n)
    {
        int min = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] > 0 && a[i, j] < min)
                {
                    min = a[i, j];
                }
            }
        }
        return min == int.MaxValue ? -1 : min;
    }
    static int TongCheoPhu(int[,] a, int n)
    {
        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == (n - 1) - i)
                {
                    tong += a[i, j];
                }
            }
        }
        return tong;
    }
    static bool KiemTraCheoChinhTangDan(int[,] a, int n)
    {
        int[] tg = new int[n];
        for (int i = 0; i < n; i++)
        {
            tg[i] = a[i, i];
        }

        for (int i = 0; i <= n - 2; i++)
        {
            for (int j = i + 1; j <= n - 1; j++)
            {
                if (tg[i] >= tg[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        int[,] a = NhapMaTran(out int n);
        InMaTran(a, n);

        Console.WriteLine($"\na. Tổng các phần tử ma trận: {TongMaTran(a, n)}");

        int minDuong = DuongNhoNhat(a, n);
        if (minDuong == -1)
            Console.WriteLine("b. Ma trận không có phần tử dương.");
        else
            Console.WriteLine($"b. Giá trị dương nhỏ nhất: {minDuong}");

        Console.WriteLine($"c. Tổng các phần tử trên đường chéo phụ: {TongCheoPhu(a, n)}");
        Console.WriteLine($"d. Đường chéo chính tăng dần: {KiemTraCheoChinhTangDan(a, n)}");
    }
}