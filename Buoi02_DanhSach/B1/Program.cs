using System;
using System.Text;

class Program
{
    static int[] NhapMang()
    {
        int n;
        do
        {
            Console.Write("Nhập số phần tử n (n > 0): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write($"Nhập a[{i}] (số nguyên dương): ");
            } while (!int.TryParse(Console.ReadLine(), out a[i]) || a[i] <= 0);
        }
        return a;
    }
    static void HienThiMang(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }
    static void ChenPhanTu(ref int[] a, int x, int k)
    {
        if (k < 0 || k > a.Length)
        {
            Console.WriteLine($"Vị trí chèn k = {k} không hợp lệ (chỉ nhận từ 0 đến {a.Length}).");
            return;
        }
        int[] tmp = new int[a.Length + 1];

        for (int i = 0; i <= k - 1; i++)
        {
            tmp[i] = a[i];
        }
        tmp[k] = x;

        for (int i = k; i <= a.Length - 1; i++)
        {
            tmp[i + 1] = a[i];
        }
        a = tmp;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int[] a = NhapMang();

        Console.WriteLine("\nDanh sách vừa nhập:");
        HienThiMang(a);

        int x, k;
        do
        {
            Console.Write("\nNhập giá trị nguyên dương x cần chèn: ");
        } while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);

        Console.Write($"Nhập vị trí k cần chèn (từ 0 đến {a.Length}): ");
        while (!int.TryParse(Console.ReadLine(), out k) || k < 0 || k > a.Length)
        {
            Console.Write($"Vị trí không hợp lệ! Nhập lại k (0..{a.Length}): ");
        }

        ChenPhanTu(ref a, x, k);

        Console.WriteLine($"\nDanh sách sau khi chèn {x} vào vị trí {k}:");
        HienThiMang(a);
    }
}