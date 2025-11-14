using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_2380601228_NgoThiBaoLoan
{
    internal class PhuongTrinhBacNhat
    {
        protected double a { get; set; }
        protected double b { get; set; }

        public PhuongTrinhBacNhat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public string GiaiPhuongTrinh()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "Phuong trinh vo so nghiem";
                }
                else
                {
                    return "Phuong trinh vo nghiem";
                }
            }
            else
            {
                double x = -(b / a);
                return $"Phuong trinh co nghiem duy nhat x = {x}";
            }
        }
    }
}
