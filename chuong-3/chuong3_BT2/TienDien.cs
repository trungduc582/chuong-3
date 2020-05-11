using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_BT2
{
    class TienDien
    {
        protected string HoTen;
        protected string DiaChi;
        protected int SoCongToThangTruoc;
        protected int SoCongToThangNay;
        protected int SoCongToDaDung;

        public TienDien()
        {
            HoTen = "";
            DiaChi = "";
            SoCongToThangTruoc = 0;
            SoCongToThangNay = 0;
        }

        public TienDien(string HoTen,String DiaChi,int SoCongToThangTruoc, int SoCongToThangNay )
        {
            this.HoTen=HoTen;
            this.DiaChi = DiaChi;
            this.SoCongToThangTruoc=SoCongToThangTruoc;
            this.SoCongToThangNay = SoCongToThangNay;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap ho ten:");
            HoTen = Console.ReadLine();
            Console.WriteLine("nhap dia chi:");
            DiaChi = Console.ReadLine();
            Console.WriteLine("nhap so cong to thang truoc:");
            SoCongToThangTruoc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so cong to thang nay:");
            SoCongToThangNay =Convert.ToInt32( Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("ho ten: " + HoTen);
            Console.WriteLine("dia chi: " + DiaChi);
            Console.WriteLine("so cong to thang truoc: " + SoCongToThangTruoc);
            Console.WriteLine("so cong to thang nay: " + SoCongToThangNay);
            Console.WriteLine("so cong to da dung: " + sodien());
        }
        public int sodien()
        {
            return SoCongToThangNay - SoCongToThangTruoc;
        }
        public float tinhtien()
        {
            return sodien() * 500;
        }
    }
    
}
