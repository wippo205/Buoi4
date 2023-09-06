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
            Point point = new Point("", 0.0f, 0.0f);
            point.NhapThongTin();

            Console.WriteLine("Tên: {point.Ten}");
            Console.WriteLine("Tọa độ X: {point.X}");
            Console.WriteLine("Tọa độ Y: {point.Y}");
            Console.ReadLine();
        }
    }
}
