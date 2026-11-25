using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Queue<string> printQueue = new Queue<string>();

        while (true)
        {
            Console.WriteLine("\n=== HỆ THỐNG IN ẤN ===");
            Console.WriteLine("1. Thêm yêu cầu in\n2. Xử lý yêu cầu in\n3. Hiển thị danh sách hàng đợi\n0. Thoát");
            Console.Write("Chọn: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Nhập tên tài liệu: ");
                printQueue.Enqueue(Console.ReadLine());
            }
            else if (choice == "2")
            {
                if (printQueue.Count > 0) Console.WriteLine("Đang in: " + printQueue.Dequeue());
                else Console.WriteLine("Không có yêu cầu in nào!");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Hàng đợi in: " + (printQueue.Count > 0 ? string.Join(" -> ", printQueue) : "Trống"));
            }
            else if (choice == "0") break;
        }
    }
}