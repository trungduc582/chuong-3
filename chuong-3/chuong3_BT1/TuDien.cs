using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_BT1
{
    class TuDien: TamGiac
    {
        private int h;
        public TuDien(int a, int b, int c, int h) : base(a, b, c)
        {
            this.h = h;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap h:");
            h = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            
            base.xuat();
            Console.WriteLine("chieu cao h: " + h);
        }
        public Double thetich()
        {
            return dientich() * h / 3;
        }
    }
        
}
