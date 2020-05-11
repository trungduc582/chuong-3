using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class nhanvien
    {
        private string hoten;
        private int namsinh;
        private string diachi;
        private int luongcoban;
        private Double heso;
        private int phucap;
        private Double tongtien;

        public nhanvien()
        {
            hoten = "";
            namsinh = 1990;
            diachi = "";
            luongcoban = 0;heso = 0;phucap = 0;tongtien = 0;
        }
        public void nhap()
        {
            Console.WriteLine("nhap ho ten:");
            hoten = Console.ReadLine();
            Console.WriteLine("nhap nam sinh:");
            namsinh =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("nhap dia chi:");
            diachi = Console.ReadLine();
            Console.WriteLine("nhap luong co ban:");
            luongcoban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap he so luong:");
            heso = Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("nhap phu cap:");
            phucap = Convert.ToInt32((Console.ReadLine()));
        }
        public double tinhluong()
        {
            return (luongcoban * heso + phucap);
        }
        public void xuat()
        {
            Console.WriteLine("ho ten: {0} \t nam sinh:{1} \t dia chi:{2} \nluong co ban:{3} \t he so:{4} \t phu cap:{5} \n tong luong:{6}"
                , hoten, namsinh, diachi, luongcoban, heso, phucap, tinhluong());
        }
    }
}
