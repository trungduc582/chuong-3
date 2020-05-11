using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_part3_bt2
{
    class khach
    {
        private string hoten;
        private Xe loaixe;
        private double sogiothue;
        public void nhap()
        {
            try
            {
                Console.Write("nhap ho ten: ");
                hoten = Console.ReadLine();
                Console.Write("nhap so gio thue: ");
                sogiothue = Convert.ToInt32(Console.ReadLine());
                Console.Write("nhap 1 neu can thue xe du lich, nhap 2 neu can thue xe tai: ");
                int kieu = Convert.ToInt32(Console.ReadLine());
                if (kieu == 1)
                    loaixe = new xedulich();
                else loaixe = new xetai();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void xuat()
        {
            Console.WriteLine("ho ten: " + hoten + "\tso gio thue: " + sogiothue + "\ttong tien: " + loaixe.tinhtien(sogiothue));
        }
    }
}
