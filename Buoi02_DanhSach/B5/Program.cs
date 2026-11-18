using System;
using System.Text;
class Node5
{
    public int Data;
    public Node5 Next;
    public Node5(int data)
    {
        Data = data;
        Next = null;
    }
}
class B5
{
    static Node5 l = null;

    static void ThemCuoi(int val)
    {
        Node5 newNode = new Node5(val);
        if (l == null)
        {
            l = newNode;
            return;
        }
        Node5 p = l;
        while (p.Next != null)
        {
            p = p.Next;
        }
        p.Next = newNode;
    }
    static int TimMax()
    {
        int max = int.MinValue;
        Node5 p = l;
        while (p != null)
        {
            if (p.Data > max)
            {
                max = p.Data;
            }
            p = p.Next;
        }
        return max;
    }
    static int TinhTong()
    {
        int t = 0;
        Node5 p = l;
        while (p != null)
        {
            t += p.Data;
            p = p.Next;
        }
        return t;
    }
    static bool KTNT(int x)
    {
        if (x < 2) return false;
        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (x % i == 0) return false;
        }
        return true;
    }
    static int DemSoNguyenTo()
    {
        int dem = 0;
        Node5 p = l;
        while (p != null)
        {
            if (KTNT(p.Data))
            {
                dem++;
            }
            p = p.Next;
        }
        return dem;
    }
    static void DemAmDuongKhong()
    {
        int demAm = 0, demDuong = 0, demKhong = 0;
        Node5 p = l;
        while (p != null)
        {
            if (p.Data < 0) demAm++;
            else if (p.Data > 0) demDuong++;
            else demKhong++;
            p = p.Next;
        }
        Console.WriteLine($"d. Số âm: {demAm} | Số dương: {demDuong} | Số bằng 0: {demKhong}");
    }
    static int DemBangX(int x)
    {
        int dem = 0;
        Node5 p = l;
        while (p != null)
        {
            if (p.Data == x)
            {
                dem++;
            }
            p = p.Next;
        }
        return dem;
    }
    static int TimMinDuong()
    {
        int minduong = int.MaxValue;
        Node5 p = l;
        while (p != null)
        {
            if (p.Data < minduong && p.Data > 0)
            {
                minduong = p.Data;
            }
            p = p.Next;
        }
        return minduong == int.MaxValue ? -1 : minduong;
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng phần tử n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            int val = int.Parse(Console.ReadLine());
            ThemCuoi(val);
        }
        Console.WriteLine($"\na. Phần tử lớn nhất: {TimMax()}");
        Console.WriteLine($"b. Tổng các phần tử: {TinhTong()}");
        Console.WriteLine($"c. Số lượng số nguyên tố: {DemSoNguyenTo()}");
        DemAmDuongKhong();

        Console.Write("\nNhập giá trị x cần đếm: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine($"e. Số lượng phần tử bằng {x}: {DemBangX(x)}");

        int minD = TimMinDuong();
        Console.WriteLine($"f. Phần tử dương nhỏ nhất: {(minD == -1 ? "Không có" : minD.ToString())}");
    }
}