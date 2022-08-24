using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static double GetHyp(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
        /*static double GetHyp(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите стор первого тр");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double S1 = GetHyp(a1, b1, c1);
            Console.WriteLine("введите стор второго тр");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double S2 = GetHyp(a2, b2, c2);
            if (S1 > S2)
                Console.WriteLine("пл перв тр больше");
            else
                if (S1 < S2)
                Console.WriteLine("пл втор тр больше");
            else
                Console.WriteLine("пл равны");
            Console.ReadKey();
            /*Console.WriteLine("введите катеты первого тр");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = GetHyp(x1,y1); 
            Console.WriteLine("введите катеты второго тр");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = GetHyp(x2,y2);
            if (z1 > z2)
                Console.WriteLine("гип перв тр больше");
            else
                if (z1 < z2)
                Console.WriteLine("гип втор тр больше");
            else
                Console.WriteLine("Гип равны");
            Console.ReadKey();*/
        }
    }
}
