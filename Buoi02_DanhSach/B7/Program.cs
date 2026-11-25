using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double[] nhietDo = new double[7];

        for (int i = 0; i < nhietDo.Length; i++)
        {
            Console.Write($"Nhập nhiệt độ ngày {i + 1}: ");
            nhietDo[i] = Convert.ToDouble(Console.ReadLine());
        }
        double max = nhietDo[0];
        double min = nhietDo[0];
        double sum = 0;
        for (int i = 0; i < nhietDo.Length; i++)
        {
            if (nhietDo[i] > max)
            {
                max = nhietDo[i];
            }
            if (nhietDo[i] < min)
            {
                min = nhietDo[i];
            }
            sum += nhietDo[i];
        }
        double average = sum / nhietDo.Length;

        Console.WriteLine($"Nhiệt độ cao nhất trong tuần: {max}°C");
        Console.WriteLine($"Nhiệt độ thấp nhất trong tuần: {min}°C");
        Console.WriteLine($"Trung bình nhiệt độ trong tuần: {average}°C");
    }
}