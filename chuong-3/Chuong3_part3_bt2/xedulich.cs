using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_part3_bt2
{
    class xedulich : Xe
    {
        //private double sogiothue;


        public override double tinhtien(double sogiothue)
        {
            double sotien = 0;

            if (sogiothue <= 1)
                sotien = 250000;
            else sotien = 250000 + (70000 * (sogiothue - 1));
            return sotien;
        }
    }
}