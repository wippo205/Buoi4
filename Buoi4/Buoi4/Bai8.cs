using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
class CD
{
    private int maCD;
    private string tuaCD;
    private int soBaiHat;
    private double giaThanh;

    public CD()
    {
        maCD = 999999;
        tuaCD = "chưa xác định";
        soBaiHat = 0;
        giaThanh = 0.0;
    }

    public CD(int maCD, string tuaCD, int soBaiHat, double giaThanh)
    {
        if (maCD > 0)
            this.maCD = maCD;
        else
            this.maCD = 999999;

        if (!string.IsNullOrEmpty(tuaCD))
            this.tuaCD = tuaCD;
        else
            this.tuaCD = "chưa xác định";

        if (soBaiHat > 0)
            this.soBaiHat = soBaiHat;
        else
            this.soBaiHat = 0;

        if (giaThanh > 0)
            this.giaThanh = giaThanh;
        else
            this.giaThanh = 0.0;
    }

    public int MaCD
    {
        get { return maCD; }
        set
        {
            if (value > 0)
                maCD = value;
        }
    }

    public string TuaCD
    {
        get { return tuaCD; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                tuaCD = value;
        }
    }

    public int SoBaiHat
    {
        get { return soBaiHat; }
        set
        {
            if (value > 0)
                soBaiHat = value;
        }
    }

    public double GiaThanh
    {
        get { return giaThanh; }
        set
        {
            if (value > 0)
                giaThanh = value;
        }
    }

    public override string ToString()
    {
        return "Mã CD: "+maCD + "Tựa CD: "+tuaCD+ "Số bài hát: "+soBaiHat+ "Giá thành: "+giaThanh;
    }
}

class CDList
{
    private CD[] cds;
    private int maxSize;
    private int currentSize;

    public CDList(int n)
    {
        maxSize = n;
        cds = new CD[maxSize];
        currentSize = 0;
    }

    public bool AddCD(CD cd)
    {
        if (currentSize >= maxSize || cds.Any(x => x != null && x.MaCD == cd.MaCD))
            return false;

        cds[currentSize] = cd;
        currentSize++;
        return true;
    }

    public int Count()
    {
        return currentSize;
    }

    public double TotalCost()
    {
        return cds.Where(x => x != null).Sum(x => x.GiaThanh);
    }

    public string GetAllCDsInfo()
    {
        string info = "";
        foreach (var cd in cds)
        {
            if (cd != null)
                info += cd.ToString() + "\n";
        }
        return info;
    }

    public void SortByPriceDescending()
    {
        cds = cds.Where(x => x != null).OrderByDescending(x => x.GiaThanh).ToArray();
    }

    public void SortByTitleAscending()
    {
        cds = cds.Where(x => x != null).OrderBy(x => x.TuaCD).ToArray();
    }
}

}

