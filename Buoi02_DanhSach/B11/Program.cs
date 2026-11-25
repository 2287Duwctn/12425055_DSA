using System;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.Write("Nhập số hàng của ma trận: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Nhập số cột của ma trận: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Nhập các phần tử của ma trận:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhập phần tử tại vị trí [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        bool isIdentity = true;
        if (rows != cols)
        {
            isIdentity = false;
        }
        else
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == j && matrix[i, j] != 1)
                    {
                        isIdentity = false;
                        break;
                    }
                    else if (i != j && matrix[i, j] != 0)
                    {
                        isIdentity = false;
                        break;
                    }
                }
                if (!isIdentity)
                {
                    break;
                }
            }
        }
        if (isIdentity)
        {
            Console.WriteLine("Ma trận là ma trận đơn vị.");
        }
        else
        {
            Console.WriteLine("Ma trận không phải là ma trận đơn vị.");
        }
        bool isSymmetric = true;
        if (rows != cols)
        {
            isSymmetric = false;
        }
        else
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        isSymmetric = false;
                        break;
                    }
                }
                if (!isSymmetric)
                {
                    break;
                }
            }
        }
        if (isSymmetric)
        {
            Console.WriteLine("Ma trận là ma trận đối xứng.");
        }
        else
        {
            Console.WriteLine("Ma trận không phải là ma trận đối xứng.");
        }
    }
}