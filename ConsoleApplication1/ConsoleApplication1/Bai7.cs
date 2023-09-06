using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Bai7
    {
public class Point
{
    private float X;
    private string ten;
    private float y;
    public float X
    {
        get { return X; }
        set { X = value; }
    }

    public float Y
    {
        get { return y; }
        set { y = value; }
    }

    public string Ten
    {
        get { return ten; }
        set { ten = value; }
    }

    public Point(float y, float x, string ten)
    {
        this.X = x;
        this.Y = y;
        this.Ten = ten;
    }
  
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


