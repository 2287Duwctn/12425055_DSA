using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static Stack<string> backStack = new Stack<string>();
    static Stack<string> forwardStack = new Stack<string>();
    static string currentPage = "";
    static void Visit(string url)
    {
        if (!string.IsNullOrEmpty(currentPage)) backStack.Push(currentPage);
        currentPage = url;
        forwardStack.Clear();
        Console.WriteLine("Đang truy cập: " + currentPage);
    }
    static void Back()
    {
        if (backStack.Count > 0)
        {
            forwardStack.Push(currentPage);
            currentPage = backStack.Pop();
            Console.WriteLine("Quay lại: " + currentPage);
        }
        else Console.WriteLine("Không thể quay lại!");
    }
    static void Forward()
    {
        if (forwardStack.Count > 0)
        {
            backStack.Push(currentPage);
            currentPage = forwardStack.Pop();
            Console.WriteLine("Tiến lên: " + currentPage);
        }
        else Console.WriteLine("Không thể tiến lên!");
    }
    static void ShowCurrentPage()
    {
        Console.WriteLine("Trang hiện tại: " + (string.IsNullOrEmpty(currentPage) ? "Trống" : currentPage));
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\n=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===");
            Console.WriteLine("1. Truy cập trang mới\n2. Quay lại\n3. Tiến lên\n4. Hiển thị trang hiện tại\n0. Thoát");
            Console.Write("Chọn: ");
            string choice = Console.ReadLine();

            if (choice == "1") { Console.Write("Nhập URL: "); Visit(Console.ReadLine()); }
            else if (choice == "2") Back();
            else if (choice == "3") Forward();
            else if (choice == "4") ShowCurrentPage();
            else if (choice == "0") break;
        }
    }
}