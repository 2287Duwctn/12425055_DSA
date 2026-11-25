using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số lượng phần tử của dãy số: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0) sum += i;
            }
            return sum == num;
        }
        int primeCount = 0, perfectCount = 0;
        Console.WriteLine("Các số nguyên tố trong dãy số:");
        for (int i = 0; i < n; i++)
        {
            if (IsPrime(arr[i]))
            {
                Console.Write(arr[i] + " ");
                primeCount++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Các số hoàn hảo trong dãy số:");
        for (int i = 0; i < n; i++)
        {
            if (IsPerfect(arr[i]))
            {
                Console.Write(arr[i] + " ");
                perfectCount++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Số lượng số nguyên tố: {primeCount}");
        Console.WriteLine($"Số lượng số hoàn hảo: {perfectCount}");
    }
}    