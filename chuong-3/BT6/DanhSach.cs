using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6
{
    class DanhSach
    {
        private int i;
        private int n;
        private SinhVien[] mangsv;
        public void nhap()
        {
            Console.WriteLine("nhap so luong sv:");
            n = Convert.ToInt32(Console.ReadLine());
            mangsv = new SinhVien[n];
            for(i = 0; i < n; i++)
            {
                mangsv[i] = new SinhVien();
                Console.WriteLine("\nnhap thong tin sv{0}", i + 1);
                mangsv[i].nhap();
            }
        }
        public void xuat()
        {
            Console.WriteLine("thong tin mang sv:");
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("\nsinh vien{0}:", i + 1);
                mangsv[i].xuat();
            }
        }
        public void xuatsvtren8()
        {
            Console.WriteLine("\nnhung sinh vien tren 8.0:");
            for (i = 0; i < n; i++)
            {
                if (mangsv[i].tinhdientb() >= 8)
                {
                    Console.WriteLine("\nsinh vien {0}",i + 1);
                    Console.WriteLine("diem tb:" + mangsv[i].tinhdientb());
                }
                    
            }
        }
        public void sapxep()
        {
            for(i=0;i<n-1;i++)
                for(int j = i + 1; j < n; j++)
                {
                    if (string.Compare(mangsv[i].MaSV, mangsv[j].MaSV, true) > 0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = mangsv[i];
                        mangsv[i] = mangsv[j];
                        mangsv[j] = tg;
                    }
                }
        }
    }
}
