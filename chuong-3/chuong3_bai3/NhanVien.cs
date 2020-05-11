using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_bai3
{
    class NhanVien
    {
        protected string HoTen;
        protected string DiaChi;
        //protected DateTime NgaySinh;
        protected int songaycong;
        protected float tiencong;
        public NhanVien()
        {
            HoTen = "";
            DiaChi = "";
            //NgaySinh = new DateTime();
        }
        public NhanVien(string Hoten, string DiaChi)
        {
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
            //this.NgaySinh = NgaySinh;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap ho ten:");
            HoTen = Console.ReadLine();
            Console.WriteLine("nhap dia chi:");
            DiaChi = Console.ReadLine();
            // Console.WriteLine("nhap Ngay sinh:");
            //NgaySinh =Convert.ToDateTime( Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("ho ten: " + HoTen + "  dia chi: " + DiaChi);

        }
        public virtual float tinhtiencong()
        {
            return (songaycong * tiencong);
        }
    }
}
