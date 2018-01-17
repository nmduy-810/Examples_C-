using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSoLonNhat_NhoNhat
{
    class Program
    {
        public static void TimSoLonNhat_NhoNhat()
        {
            int a, b, c, d;
            Console.Write("Nhap so a bat ky : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b bat ky : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c bat ky : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Nhap so d bat ky : ");
            d = int.Parse(Console.ReadLine());

            int max = a;
            max = max < b ? b : max;
            max = max < c ? c : max;
            max = max < d ? d : max;

            int min = a;
            min = min > b ? b : min;
            min = min > c ? c : min;
            min = min > d ? d : min;
            

            Console.WriteLine(max + " la so lon nhat ");
            Console.WriteLine(min + " la so lon nhat ");





        }
        static void Main(string[] args)
        {
            TimSoLonNhat_NhoNhat();

            Console.ReadKey();
        }
    }
}
