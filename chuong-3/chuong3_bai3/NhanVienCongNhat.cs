using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_bai3
{
    class NhanVienCongNhat:NhanVien
    {
        private int songaycong;
        public NhanVienCongNhat(string Hoten, string DiaChi, int songaycong)
                                : base(Hoten, DiaChi)
        {
            this.songaycong = songaycong;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap so ngay cong:");
            songaycong = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("so ngay cong: " + songaycong);
        }
        public override float tinhtiencong()
        {
            return songaycong * 90000;
        }
    }
}
