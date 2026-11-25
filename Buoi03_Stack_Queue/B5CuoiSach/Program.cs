using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static string CheckParentheses(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(') stack.Push(c);
            else if (c == ')')
            {
                if (stack.Count == 0) return "Xâu sai";
                stack.Pop();
            }
            else return "Xâu sai";
        }
        return stack.Count == 0 ? "Xâu đúng" : "Xâu sai";
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập chuỗi ngoặc: ");
        Console.WriteLine(CheckParentheses(Console.ReadLine()));
    }
}