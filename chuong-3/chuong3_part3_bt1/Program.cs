using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_part3_bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSV k21httta = new DanhSachSV();
            k21httta.nhap();
            k21httta.xuat();
            Console.WriteLine("so luong sv lam khoa luan: " + k21httta.soluongsvkhoaluan());
            Console.WriteLine("so luong sv lam chuyen de: " + k21httta.soluongsvchuyende());
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------duc ngau qua di---------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.Read();
        }
    }
}
