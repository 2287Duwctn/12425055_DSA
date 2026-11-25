using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static bool IsValidExpression(string expr)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in expr)
        {
            if (c == '(' || c == '[' || c == '{') stack.Push(c);
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
                    return false;
            }
        }
        return stack.Count == 0;
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập biểu thức: ");
        Console.WriteLine(IsValidExpression(Console.ReadLine()) ? "Biểu thức hợp lệ" : "Biểu thức sai");
    }
}