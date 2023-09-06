using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    
     class HinhTron
        {
            public Point Tam { get; set; }
            public double BanKinh { get; set; }

            public HinhTron(Point tam, double banKinh)
            {
                Tam = tam;
                BanKinh = banKinh;
            }

            public double TinhDienTich()
            {
                return Math.PI * BanKinh * BanKinh;
            }

            public double TinhChuVi()
            {
                return 2 * Math.PI * BanKinh;
            }

            public override string ToString()
            {
                return "Hình tròn có tâm "+(Tam.X+ Tam.Y)+"\t"+ "với bán kính "+BanKinh;
            }
        }
}


