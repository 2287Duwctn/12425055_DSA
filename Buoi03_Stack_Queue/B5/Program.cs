using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Queue<string> networkQueue = new Queue<string>();

        networkQueue.Enqueue("Packet #1 [SYN]");
        networkQueue.Enqueue("Packet #2 [ACK]");
        networkQueue.Enqueue("Packet #3 [DATA]");

        while (networkQueue.Count > 0)
        {
            Console.WriteLine("Xử lý gói tin: " + networkQueue.Dequeue());
        }
    }
}