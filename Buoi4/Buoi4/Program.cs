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

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Point point = new Point("", 0.0f, 0.0f);
            point.NhapThongTin();

            string info = point.ToString();
            Console.WriteLine(info);
            


            Point tam = new Point(3,3);
            double banKinh = 10.5;

        HinhTron hinhTron = new HinhTron(tam, banKinh);

        Console.WriteLine(hinhTron.ToString());
        Console.WriteLine("Diện tích: {0}",hinhTron.TinhDienTich());
        Console.WriteLine("Chu vi: {0}",hinhTron.TinhChuVi());
        Console.ReadLine();
        }
    }
}
