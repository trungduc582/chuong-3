
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_part3_bt2
{
    class quanly
    {
        private khach[] DS;
        private int soluong;
        public void nhap()
        {
            Console.Write("nhap so luong khach hang: ");
            soluong = Convert.ToInt32(Console.ReadLine());
            DS = new khach[soluong];
            for (int i = 0; i < soluong; i++)
            {
                DS[i] = new khach();
                Console.WriteLine("\nnhap thong tin khach hang{0}: ", i + 1);
                DS[i].nhap();
            }
        }
        public void xuat()
        {
            Console.WriteLine("\nthong tin danh sach khach hang:");
            for (int i = 0; i < soluong; i++)
            {
                Console.WriteLine("\nthong tin khach hang{0}", i + 1);
                DS[i].xuat();
            }
        }
    }
}