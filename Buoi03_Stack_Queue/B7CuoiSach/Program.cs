using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Queue<string> networkQueue = new Queue<string>();

        while (true)
        {
            Console.WriteLine("\n=== ĐƯỜNG TRUYỀN DỮ LIỆU ===");
            Console.WriteLine("1. Gửi dữ liệu\n2. Nhận dữ liệu\n3. Hiển thị dữ liệu trong hàng đợi\n0. Thoát");
            Console.Write("Chọn: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Nhập gói dữ liệu: ");
                networkQueue.Enqueue(Console.ReadLine());
            }
            else if (choice == "2")
            {
                if (networkQueue.Count > 0) Console.WriteLine("Đã nhận: " + networkQueue.Dequeue());
                else Console.WriteLine("Không có dữ liệu để nhận!");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Hàng đợi: " + (networkQueue.Count > 0 ? string.Join(" -> ", networkQueue) : "Rỗng"));
            }
            else if (choice == "0") break;
        }
    }
}