using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static Stack<string> callStack = new Stack<string>();
    static void CallFunction(string funcInfo)
    {
        callStack.Push(funcInfo);
        Console.WriteLine($"[CALL] Đẩy vào Stack: {funcInfo}");
        Console.WriteLine("  -> Call Stack: " + string.Join(" | ", callStack));
    }
    static void ReturnFunction()
    {
        if (callStack.Count > 0)
        {
            Console.WriteLine($"[RETURN] Lấy ra: {callStack.Pop()}");
            Console.WriteLine("  -> Call Stack: " + (callStack.Count > 0 ? string.Join(" | ", callStack) : "Rỗng"));
        }
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        CallFunction("Main()");
        CallFunction("TinhTong(5, 3)");
        CallFunction("KiemTra(5)");
        ReturnFunction();
        ReturnFunction();
        ReturnFunction();
    }
}