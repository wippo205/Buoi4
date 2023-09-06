using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Point
    {
        private string ten;
        private float x;
        private float y;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(string ten, float x, float y)
        {
            this.Ten = ten;
            this.X = x;
            this.Y = y;
        }

        public Point(float x, float y)
        {
            Ten = "";
            X = x;
            Y = y;
        }

        public Point()
        {
            Ten = "";
            X = 0.0f;
            Y = 0.0f;
        }

        public void NhapThongTin()
        {
            Console.Write("Nhập tên: ");
            Ten = Console.ReadLine();

            Console.Write("Nhập tọa độ X: ");
            X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập tọa độ Y: ");
            Y = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
    {
        return "Tên: " + Ten + "\n" + "Tọa độ X: " + X + "\n" + "Tọa độ Y: " + Y;
    }
    }
}


