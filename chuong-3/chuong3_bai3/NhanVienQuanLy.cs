using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_bai3
{
    class NhanVienQuanLy:NhanVien
    {
        private int hesoluong;
        private int luongcoban;
        public NhanVienQuanLy(string Hoten, string DiaChi, int hesoluong, int luongcoban)
                                : base(Hoten, DiaChi)
        {
            this.hesoluong = hesoluong;
            this.luongcoban = luongcoban;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap he so luong:");
            hesoluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap luong co ban:");
            luongcoban = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("he so luong: " + hesoluong + " luong co ban: " + luongcoban);
        }
        public override float tinhtiencong()
        {
            return hesoluong * luongcoban;
        }
    }
}
