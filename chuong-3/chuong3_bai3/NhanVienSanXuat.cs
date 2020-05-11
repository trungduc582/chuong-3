using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_bai3
{
    class NhanVienSanXuat:NhanVien
    {
        private int sosanpham;
        public NhanVienSanXuat(string Hoten, string DiaChi, int sosanpham)
                                : base(Hoten, DiaChi)
        {
            this.sosanpham = sosanpham;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap so san pham:");
            sosanpham = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("so san pham: " + sosanpham);
        }
        public override float tinhtiencong()
        {
            return sosanpham * 30000;
        }
    }
}
