using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string chuoi = "Hello, World!";
        chuoi = chuoi.ToLower().Trim();
        Console.WriteLine(chuoi);

        string[] tu = chuoi.Split(' ');
        Console.WriteLine("Các từ trong chuỗi:");
        foreach (string t in tu)
        {
            Console.WriteLine(t);
        }
        var tanSuat = new System.Collections.Generic.Dictionary<string, int>();
        foreach (string t in tu)
        {
            if (tanSuat.ContainsKey(t))
            {
                tanSuat[t]++;
            }
            else
            {
                tanSuat[t] = 1;
            }
        }
        Console.WriteLine("Tần suất xuất hiện của các từ:");
        foreach (var kvp in tanSuat)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        var sapXep = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, int>>(tanSuat);
        sapXep.Sort((x, y) => y.Value.CompareTo(x.Value));
        Console.WriteLine("Kết quả sau khi sắp xếp:");
        foreach (var kvp in sapXep)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}