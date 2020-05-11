using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVienSanXuat nv2 = new NhanVienSanXuat("trung", "vp", 10);
            //nv2.nhap();
            nv2.xuat();
            Console.WriteLine("tong tien cong: " + nv2.tinhtiencong());
            NhanVienCongNhat nv3 = new NhanVienCongNhat("duc", "yl", 20);
            //nv3.nhap();
            nv3.xuat();
            Console.WriteLine("tong tien cong: " + nv3.tinhtiencong());
            NhanVienQuanLy nv4 = new NhanVienQuanLy("nguyen", "lc", 2, 3000000);
            //nv4.nhap();
            nv4.xuat();
            Console.WriteLine("tong tien cong: " + nv4.tinhtiencong());
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------duc ngau qua di---------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
