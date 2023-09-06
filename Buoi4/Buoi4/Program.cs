using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 7");
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Point point = new Point("", 0.0f, 0.0f);
            point.NhapThongTin();

            string info = point.ToString();
            Console.WriteLine(info);
            


            Point tam = new Point(5, 5);
            double banKinh = 10.5;

        HinhTron hinhTron = new HinhTron(tam, banKinh);

        Console.WriteLine(hinhTron.ToString());
        Console.WriteLine("Diện tích: {0}",hinhTron.TinhDienTich());
        Console.WriteLine("Chu vi: {0}",hinhTron.TinhChuVi());
        Console.ReadLine();

        Console.WriteLine("Bai 8");  
        Console.WriteLine("Nhập số lượng CD: ");
        int n = int.Parse(Console.ReadLine());

        CDList cdList = new CDList(n);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhập thông tin cho CD thứ {0}:",i + 1);
            Console.Write("Mã CD: ");
            int maCD = int.Parse(Console.ReadLine());
            Console.Write("Tựa CD: ");
            string tuaCD = Console.ReadLine();
            Console.Write("Số bài hát: ");
            int soBaiHat = int.Parse(Console.ReadLine());
            Console.Write("Giá thành: ");
            double giaThanh = double.Parse(Console.ReadLine());

            CD cd = new CD(maCD, tuaCD, soBaiHat, giaThanh);

            if (cdList.AddCD(cd))
                Console.WriteLine("Thêm CD thành công!");
            else
                Console.WriteLine("Thêm CD không thành công! Mã CD trùng hoặc danh sách đã đầy.");
        }

        Console.WriteLine("\nDanh sách CD:");
        Console.WriteLine(cdList.GetAllCDsInfo());

        Console.WriteLine("Tổng giá thành của các CD: {0}",cdList.TotalCost());

        Console.WriteLine("\nSắp xếp danh sách theo giá thành giảm dần:");
        cdList.SortByPriceDescending();
        Console.WriteLine(cdList.GetAllCDsInfo());

        Console.WriteLine("\nSắp xếp danh sách theo tựa CD tăng dần:");
        cdList.SortByTitleAscending();
        Console.WriteLine(cdList.GetAllCDsInfo());
    
        }
    }
}
