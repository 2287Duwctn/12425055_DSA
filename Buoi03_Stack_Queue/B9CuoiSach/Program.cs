using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static float EvaluatePostfix(string postfix)
    {
        Stack<float> stack = new Stack<float>();
        string[] tokens = postfix.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string s in tokens)
        {
            if (float.TryParse(s, out float num)) stack.Push(num);
            else
            {
                float a = stack.Pop();
                float b = stack.Pop();
                switch (s)
                {
                    case "+": stack.Push(b + a); break;
                    case "-": stack.Push(b - a); break;
                    case "*": stack.Push(b * a); break;
                    case "/": stack.Push(b / a); break;
                }
            }
        }
        return stack.Pop();
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập biểu thức hậu tố (VD: 3 4 2 * +): ");
        Console.WriteLine("Giá trị biểu thức: " + EvaluatePostfix(Console.ReadLine()));
    }
}