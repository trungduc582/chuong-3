using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac TG1 = new TamGiac();
            TG1.nhap();
            TG1.xuat();
            Console.WriteLine("diện tích tam giác: " + TG1.dientich());
            TuDien TD1 = new TuDien(3,4,5,6);
            TD1.nhap();
            TD1.xuat();
            Console.WriteLine("the tich tu dien: " + TD1.thetich());
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------duc ngau qua di---------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        
    }
}
