using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.Write("Nhập số hàng của ma trận: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Nhập số cột của ma trận: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];

        int top = 0, bottom = rows - 1, left = 0, right = cols - 1;

        Console.WriteLine("Nhập các phần tử của ma trận:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhập phần tử tại vị trí [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Các phần tử của ma trận theo thứ tự xoắn ốc:");
        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++)
            {
                Console.Write(matrix[top, j] + " ");
            }
            top++;
            for (int i = top; i <= bottom; i++)
            {
                Console.Write(matrix[i, right] + " ");
            }
            right--;
            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                {
                    Console.Write(matrix[bottom, j] + " ");
                }
                bottom--;
            }
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    Console.Write(matrix[i, left] + " ");
                }
                left++;
            }
        }
    }
}