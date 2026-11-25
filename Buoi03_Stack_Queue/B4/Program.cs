using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Queue<string> printQueue = new Queue<string>();

        printQueue.Enqueue("TaiLieu_01.pdf");
        printQueue.Enqueue("BaoCao_DSA.docx");
        printQueue.Enqueue("BangDiem.xlsx");

        while (printQueue.Count > 0)
        {
            Console.WriteLine("Đang in: " + printQueue.Dequeue());
        }
    }
}