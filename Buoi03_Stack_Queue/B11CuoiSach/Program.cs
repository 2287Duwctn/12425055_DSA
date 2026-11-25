using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static bool IsOperator(char c) => c == '+' || c == '-' || c == '*' || c == '/';
    static int Priority(string op)
    {
        if (op == "*" || op == "/") return 2;
        if (op == "+" || op == "-") return 1;
        return 0;
    }
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
                if (i > 0 && s[i - 1] == ')') return false;
            }
            else if (c == '(')
            {
                if (i > 0 && (char.IsDigit(s[i - 1]) || s[i - 1] == ')')) return false;
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(') return false;
                if (i > 0 && (IsOperator(s[i - 1]) || s[i - 1] == '(')) return false;
            }
            else if (IsOperator(c))
            {
                if (i > 0 && (IsOperator(s[i - 1]) || s[i - 1] == '(')) return false;
            }
            else return false;
        }
        return stack.Count == 0;
    }
    static List<string> Tokenize(string expr)
    {
        List<string> tokens = new List<string>();
        string s = expr.Replace(" ", "");
        int i = 0;
        while (i < s.Length)
        {
            if (char.IsDigit(s[i]))
            {
                string num = "";
                while (i < s.Length && char.IsDigit(s[i])) { num += s[i]; i++; }
                tokens.Add(num);
            }
            else { tokens.Add(s[i].ToString()); i++; }
        }
        return tokens;
    }
    static string InfixToPostfix(string infix)
    {
        Stack<string> st = new Stack<string>();
        StringBuilder e1 = new StringBuilder();
        foreach (string s in Tokenize(infix))
        {
            if (s == "(") st.Push(s);
            else if (s == ")")
            {
                while (st.Count > 0 && st.Peek() != "(") e1.Append(st.Pop() + " ");
                if (st.Count > 0) st.Pop();
            }
            else if (float.TryParse(s, out _)) e1.Append(s + " ");
            else
            {
                while (st.Count > 0 && Priority(st.Peek()) >= Priority(s)) e1.Append(st.Pop() + " ");
                st.Push(s);
            }
        }
        while (st.Count > 0) e1.Append(st.Pop() + " ");
        return e1.ToString().Trim();
    }
    static float EvaluatePostfix(string postfix)
    {
        Stack<float> stack = new Stack<float>();
        foreach (string s in postfix.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
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
        Console.Write("Nhập biểu thức trung tố (VD: 3 + 5 * (2 - 4)): ");
        string infix = Console.ReadLine();

        if (!IsValidInfix(infix))
        {
            Console.WriteLine("Lỗi: Biểu thức trung tố không hợp lệ!");
            return;
        }
        string postfix = InfixToPostfix(infix);
        Console.WriteLine("Biểu thức hậu tố: " + postfix);
        Console.WriteLine("Kết quả tính toán: " + EvaluatePostfix(postfix));
    }
}