using System;
using System.Text;
public class Program
{
    struct NhanVien
    {
        public string MaNV;
        public string Hoten;
        public int Namsinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;
    }
    class VD
    {
        static NhanVien[] DS;
        static int thuclinh(int i)
        {
            return DS[i].LuongCB + DS[i].Thuong;
        }
        static int tongthuclinh()
        {
            int tong = 0;
            for (int i = 0; i < DS.Length; i++)
            {
                tong += thuclinh(i);
            }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng nhân viên n: ");
            int n = int.Parse(Console.ReadLine());
            DS = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin nhân viên thứ {i + 1}:");
                Console.Write("Mã NV: ");
                DS[i].MaNV = Console.ReadLine();
                Console.Write("Họ tên: ");
                DS[i].Hoten = Console.ReadLine();
                Console.Write("Năm sinh: ");
                DS[i].Namsinh = int.Parse(Console.ReadLine());
                Console.Write("Phòng ban: ");
                DS[i].Phongban = Console.ReadLine();
                Console.Write("Lương cơ bản: ");
                DS[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("Thưởng: ");
                DS[i].Thuong = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nTổng thực lĩnh tháng : " + tongthuclinh());

            int min = int.MaxValue;
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].LuongCB < min)
                {
                    min = DS[i].LuongCB;
                }
            }
            Console.WriteLine("Lương cơ bản thấp nhất: " + min);
            Console.WriteLine("Danh sách nhân viên có lương cơ bản thấp nhất:");
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].LuongCB == min)
                {
                    Console.WriteLine($"- Mã NV: {DS[i].MaNV}, Họ tên: {DS[i].Hoten}, Năm sinh: {DS[i].Namsinh}, Phòng ban: {DS[i].Phongban}, Lương CB: {DS[i].LuongCB}, Thưởng: {DS[i].Thuong}");
                }
            }
            int dem = 0;
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].Thuong >= 1200000)
                {
                    dem++;
                }
            }
            Console.WriteLine("Số lượng nhân viên có thưởng >= 1.200.000: " + dem);
            for (int i = 0; i < DS.Length - 1; i++)
            {
                for (int j = 0; j < DS.Length - 1 - i; j++)
                {
                    if (DS[j].Phongban.CompareTo(DS[j + 1].Phongban) > 0 || (DS[j].Phongban == DS[j + 1].Phongban && DS[j].MaNV.CompareTo(DS[j + 1].MaNV) < 0))
                    {
                        NhanVien temp = DS[j];
                        DS[j] = DS[j + 1];
                        DS[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nDanh sách nhân viên sau khi sắp xếp theo phòng ban và mã NV:");
            for (int i = 0; i < DS.Length; i++)
            {
                Console.WriteLine($"- Mã NV: {DS[i].MaNV}, Họ tên: {DS[i].Hoten}, Năm sinh: {DS[i].Namsinh}, Phòng ban: {DS[i].Phongban}, Lương CB: {DS[i].LuongCB}, Thưởng: {DS[i].Thuong}");
            }

            Console.WriteLine("\nDanh sách nhân viên sau khi tăng lương cơ bản lên 5%:");
            for (int i = 0; i < DS.Length; i++)
            {
                DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
                Console.WriteLine($"- Mã NV: {DS[i].MaNV}, Họ tên: {DS[i].Hoten}, Năm sinh: {DS[i].Namsinh}, Phòng ban: {DS[i].Phongban}, Lương CB mới: {DS[i].LuongCB}, Thưởng: {DS[i].Thuong}, Thực lĩnh mới: {thuclinh(i)}");
            }
        }
    }
}