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
            Console.WriteLine("Back -> " + currentPage);
        }
        else Console.WriteLine("Không thể Back!");
    }
    static void Forward()
    {
        if (forwardStack.Count > 0)
        {
            backStack.Push(currentPage);
            currentPage = forwardStack.Pop();
            Console.WriteLine("Forward -> " + currentPage);
        }
        else Console.WriteLine("Không thể Forward!");
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Visit("google.com");
        Visit("youtube.com");
        Visit("github.com");
        Back();
        Back();
        Forward();
    }
}