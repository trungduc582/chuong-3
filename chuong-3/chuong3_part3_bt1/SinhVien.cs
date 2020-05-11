using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_part3_bt1
{
    class SinhVien
    {
        private string hoten;
        private int namsinh;
        private double diemlt, diemcsdl, diemtkw, diemtb;

        public SinhVien()
        {
            hoten = "";
            namsinh = 2000;
            diemlt = diemcsdl = diemtkw = 0;
        }

        public SinhVien(string hoten,int ns,double diemlt,double diemcsdl,double diemtkw)
        {
            this.hoten = hoten;
            this.namsinh = ns;
            this.diemlt = diemlt;
            this.diemcsdl = diemcsdl;
            this.diemtkw = diemtkw;
        }
        public void nhap()
        {
            Console.Write("nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("nhap nam sinh: ");
            namsinh = int.Parse(Console.ReadLine());
            Console.Write("nhap diem lt: ");
            diemlt = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap diem csdl: ");
            diemcsdl = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap diem thiet ke web: ");
            diemtkw = Convert.ToDouble(Console.ReadLine());
        }

        public int kieutotnghiep()
        {
            // 1: duoc lam khoa luan; 2 duoc lam chuyen de, 0: truot
            int kieu = 0;
            diemtb = (diemlt + diemcsdl + diemtkw) / 3.0;
            bool duoctotnghiep = false;
            if ((diemlt >= 5) & (diemcsdl >= 5) & (diemtkw >= 5))
                duoctotnghiep = true;
            if (duoctotnghiep==true)
            {
                if (diemtb >= 8)
                    kieu = 1;
                else kieu = 2;
            }
            return kieu;
        }

        public void xuat()
        {
            Console.WriteLine("ho ten: " + hoten + "\tnam sinh: " + namsinh + "\ndiem lt: " + diemlt + "\tdiem csdl: " + diemcsdl +
                "\tdiem thiet ke web: " + diemtkw + "\ndiem trung binh: " + diemtb);
        }
      
    }
}
