using System;
using System.Text;
class Node
{
    public int Data;
    public Node Next;
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}
class B4
{
    static Node pHead = null;
    static void ThemCuoi(int val)
    {
        Node newNode = new Node(val);
        if (pHead == null)
        {
            pHead = newNode;
            return;
        }
        Node p = pHead;
        while (p.Next != null)
        {
            p = p.Next;
        }
        p.Next = newNode;
    }
    static void InDanhSach()
    {
        Node p = pHead;
        while (p != null)
        {
            Console.Write(p.Data + " -> ");
            p = p.Next;
        }
        Console.WriteLine("null");
    }
    static int DemBangX(int x)
    {
        int d = 0;
        Node p = pHead;
        while (p != null)
        {
            if (p.Data == x)
            {
                d = d + 1;
            }
            p = p.Next;
        }
        return d;
    }
    static int TimMinDuong()
    {
        int minduong = int.MaxValue;
        Node p = pHead;
        while (p != null)
        {
            if (p.Data > 0 && p.Data < minduong)
            {
                minduong = p.Data;
            }
            p = p.Next;
        }
        return minduong == int.MaxValue ? -1 : minduong;
    }
    static void XoaPhanTuDauTien(int x)
    {
        Node p = pHead;
        Node t = null;

        while (p != null && p.Data != x)
        {
            t = p;
            p = p.Next;
        }
        if (p == null)
        {
            Console.WriteLine($"Không tìm thấy {x} trong danh sách.");
            return;
        }
        if (p == pHead)
        {
            pHead = pHead.Next;
        }
        else
        {
            t.Next = p.Next;
        }
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng phần tử n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1} (số nguyên dương): ");
            int val = int.Parse(Console.ReadLine());
            ThemCuoi(val);
        }
        Console.WriteLine("\nDanh sách vừa nhập:");
        InDanhSach();

        Console.Write("\nNhập giá trị x cần đếm: ");
        int xDem = int.Parse(Console.ReadLine());
        Console.WriteLine($"a. Số lượng phần tử bằng {xDem}: {DemBangX(xDem)}");

        int minD = TimMinDuong();
        Console.WriteLine($"b. Phần tử dương nhỏ nhất: {(minD == -1 ? "Không có" : minD.ToString())}");

        Console.Write("\nc. Nhập giá trị x cần xóa (xuất hiện đầu tiên): ");
        int xXoa = int.Parse(Console.ReadLine());
        XoaPhanTuDauTien(xXoa);
        Console.WriteLine("Danh sách sau khi xóa:");
        InDanhSach();
    }
}