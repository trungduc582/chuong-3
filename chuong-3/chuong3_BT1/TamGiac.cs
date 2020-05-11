using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_BT1
{
    class TamGiac
    {
        protected int a, b, c;
        public TamGiac()
        {
            a = b = c = 0;
        }
        public TamGiac(int a,int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap c:");
            c = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void xuat()
        {
            
            Console.WriteLine("canh a: " + a + "canh b: " + b + "canh c: " + c);
        }
        public double dientich()
        {
            Double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        
    }
}
