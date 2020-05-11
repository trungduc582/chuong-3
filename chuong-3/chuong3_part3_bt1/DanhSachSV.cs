using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_part3_bt1
{
    class DanhSachSV
    {
        private int n, i;
        private SinhVien[] DS;
        public void nhap()
        {
            Console.Write("nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            DS = new SinhVien[n];
            for (i = 0; i < n; i++)
            {
                DS[i] = new SinhVien();
                Console.WriteLine("\nnhap thong tin sv{0}:", i + 1);
                DS[i].nhap();
            }
        }
        public void xuat()
        {
            Console.WriteLine("DS sinh vien:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nthong tin sv" + i + 1);
                DS[i].xuat();
            }
        }
        public int soluongsvkhoaluan()
        {
            int dem = 0;
            for (i = 0; i < n; i++)
            {
                if (DS[i].kieutotnghiep() == 1)
                    dem++;
            }
            return dem;
        }
        public int soluongsvchuyende()
        {
            int dem = 0;
            for (i = 0; i < n; i++)
            {
                if (DS[i].kieutotnghiep() == 2);
                dem++;
            }
            return dem;
        }
    }
}
