using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6
{
    class SinhVien
    {
        private string masv;
        protected string hoten;
        protected int namsinh;
        protected double diemlt;
        protected double diemcsdl;
        protected double diemtb;

        public string MaSV
        {
            get
            {    
                return masv;
            }
            set
            {  
                this.masv = value ;
            }
        }
        public SinhVien()
        {
            masv = "";
            namsinh = 2000;
            diemlt = diemcsdl = 0;
        }
        public SinhVien(string masv,int namsinh,string hoten,double diemlt,double diemcsdl)
        {
            this.masv = masv;
            this.namsinh = namsinh;
            this.hoten = hoten;
            this.diemlt = diemlt;
            this.diemcsdl = diemcsdl;
        }
        public void nhap()
        {
            Console.WriteLine("nhap ma sv:");
            masv = Console.ReadLine();
            Console.WriteLine("nhap ho ten:");
            hoten = Console.ReadLine();
            Console.WriteLine("nhap nam sinh:");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap diem lt:");
            diemlt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap diem csdl:");
            diemcsdl = Convert.ToDouble((Console.ReadLine()));
        }
        public double tinhdientb()
        {
            return (diemcsdl + diemlt) * 0.5;
        }
        public void xuat()
        {
            Console.WriteLine("masv:{0} \t ho ten:{1} \t nam sinh:{2}\ndiem lap trinh:{3} \t diem csdl:{4}\ndiem tb:{5}"
                , masv, hoten, namsinh, diemlt, diemcsdl, tinhdientb());
        }
    }
}
