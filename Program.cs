using System;

namespace Buoi1_2380601228_NgoThiBaoLoan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Giai Phuong Trinh Bac Hai---");
            Console.WriteLine();

            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());


            PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);

            Console.WriteLine("\nKet qua la:");
            Console.WriteLine(pt.GiaiPhuongTrinh1());
        }
    }
}
