using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_BT2
{
    class TienDienMoi:TienDien
    {
        protected int DinhMuc;
        public TienDienMoi(string HoTen, String DiaChi, int SoCongToThangTruoc, int SoCongToThangNay, int DinhMuc)
                           : base(HoTen, DiaChi, SoCongToThangTruoc, SoCongToThangNay)
        {
            this.DinhMuc = DinhMuc;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap dinh muc:");
            DinhMuc = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Dinh muc: " + DinhMuc);
        }
        public float tinhtien()
        {
            if (sodien() <= DinhMuc)
                return sodien() * 500;
            else return (DinhMuc * 500 + (sodien() - DinhMuc) * 600);
        }
        
    }
}
