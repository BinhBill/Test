using System;

namespace GIAI_PHUONG_TRINH_BAC_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap c:");
            c = int.Parse(Console.ReadLine());
            int delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("PT da cho Vo Nghiem");
            }
            else

            Console.WriteLine("Hello World!");
        }
    }
}
