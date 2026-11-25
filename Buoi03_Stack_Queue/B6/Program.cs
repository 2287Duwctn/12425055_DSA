using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Queue<string> customerQueue = new Queue<string>();

        customerQueue.Enqueue("KH01 - Nguyễn Văn A (14:00 - Mở thẻ)");
        customerQueue.Enqueue("KH02 - Trần Thị B (14:05 - Nộp tiền)");
        customerQueue.Enqueue("KH03 - Lê Văn C (14:10 - Tư vấn)");

        while (customerQueue.Count > 0)
        {
            Console.WriteLine("Đang phục vụ: " + customerQueue.Dequeue());
        }
    }
}