using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_2380601228_NgoThiBaoLoan
{
    internal class PhuongTrinhBacHai : PhuongTrinhBacNhat
    {
        private double c { get; set; }


        public PhuongTrinhBacHai(double a, double b, double c) : base(a, b)
        {
            this.c = c;
        }

        public string GiaiPhuongTrinh1()
        {
            double delta = b * b - 4 * a * c;
            if (a == 0)
            {
                PhuongTrinhBacNhat PTBac1 = new PhuongTrinhBacNhat(b, c);
                return PTBac1.GiaiPhuongTrinh();
            }
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"Phuong trinh co 2 nghiem phan biet la {x1:F1} va {x2:F1}";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"Phuong trinh co nghiem kep la {x:F1}";
            }
            else
            {
                return "Phuong trinh vo nghiem";
            }
        }
    }
}
