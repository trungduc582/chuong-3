using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            nhanvien nv1 = new nhanvien();
            nv1.nhap();
            nv1.xuat();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------duc ngau qua di---------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.Read();
        }
    }
}
