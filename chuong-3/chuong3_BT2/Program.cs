using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            TienDien TD1 = new TienDien();
            TD1.nhap();
            TD1.xuat();
            Console.WriteLine("so tien phai dong: " + TD1.tinhtien());
            TienDienMoi TD2 = new TienDienMoi("MinhAnh", "Hai Duong", 20, 30,5);
            TD2.nhap();
            TD2.xuat();
            Console.WriteLine("so tien phai dong: " + TD2.tinhtien());
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------duc ngau qua di---------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
