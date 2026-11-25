using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static bool IsOperator(char c) => c == '+' || c == '-' || c == '*' || c == '/';
    static bool IsOpenBracket(char c) => c == '(' || c == '[' || c == '{';
    static bool IsCloseBracket(char c) => c == ')' || c == ']' || c == '}';
    static bool IsMatching(char open, char close) =>
        (open == '(' && close == ')') || (open == '[' && close == ']') || (open == '{' && close == '}');
    static bool IsValidInfix(string expr)
    {
        string s = expr.Replace(" ", "");
        if (string.IsNullOrEmpty(s)) return false;
        if (IsOperator(s[0]) || IsOperator(s[s.Length - 1])) return false;

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (char.IsDigit(c))
            {
                if (i > 0 && IsCloseBracket(s[i - 1])) return false;
            }
            else if (IsOpenBracket(c))
            {
                if (i > 0 && (char.IsDigit(s[i - 1]) || IsCloseBracket(s[i - 1]))) return false;
                stack.Push(c);
            }
            else if (IsCloseBracket(c))
            {
                if (stack.Count == 0 || !IsMatching(stack.Pop(), c)) return false;
                if (i > 0 && (IsOperator(s[i - 1]) || IsOpenBracket(s[i - 1]))) return false;
            }
            else if (IsOperator(c))
            {
                if (i > 0 && (IsOperator(s[i - 1]) || IsOpenBracket(s[i - 1]))) return false;
            }
            else return false;
        }
        return stack.Count == 0;
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập biểu thức trung tố: ");
        Console.WriteLine(IsValidInfix(Console.ReadLine()) ? "Biểu thức hợp lệ" : "Biểu thức không hợp lệ");
    }
}