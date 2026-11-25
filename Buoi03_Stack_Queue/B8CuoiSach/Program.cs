using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Queue<string> customerQueue = new Queue<string>();

        while (true)
        {
            Console.WriteLine("\n=== DỊCH VỤ KHÁCH HÀNG ===");
            Console.WriteLine("1. Thêm khách hàng\n2. Phục vụ khách hàng\n3. Hiển thị danh sách khách hàng chờ\n0. Thoát");
            Console.Write("Chọn: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Nhập tên/STT khách hàng: ");
                customerQueue.Enqueue(Console.ReadLine());
            }
            else if (choice == "2")
            {
                if (customerQueue.Count > 0) Console.WriteLine("Đang phục vụ: " + customerQueue.Dequeue());
                else Console.WriteLine("Không có khách hàng nào trong hàng đợi!");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Danh sách chờ: " + (customerQueue.Count > 0 ? string.Join(" -> ", customerQueue) : "Trống"));
            }
            else if (choice == "0") break;
        }
    }
}