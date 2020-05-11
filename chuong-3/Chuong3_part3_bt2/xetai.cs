
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_part3_bt2
{
    class xetai : Xe
    {
        private double sogiothue;
        public override double tinhtien(double sogiothue)
        {
            double sotien;
            if (sogiothue <= 1)
                sotien = 220000;
            else sotien = 250000 + (85000 * (sogiothue - 1));
            return sotien;
        }
    }
}