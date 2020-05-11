using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSach k21httta = new DanhSach();
            k21httta.nhap();
            k21httta.sapxep();
            k21httta.xuat();
            k21httta.xuatsvtren8();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------duc ngau qua di---------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
