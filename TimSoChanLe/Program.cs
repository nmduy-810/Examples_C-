using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_1
{
    class Program
    {
        //Nhập 2 số, xuất ra số chẵn hay số lẻ
        public static void TimSoChanLe()
        {
            int n;
            Console.Write("Nhap 1 so bat ky : ");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("n phai lon hon 0");
                return;
            }
            if (n > 0)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n + " la so chan");
                }
                else
                {
                    Console.WriteLine(n + " la so le ");
                }
            }
            if (n == 0)
            {
                Console.WriteLine(n + " la so chan ");
            }
        }

        static void Main(string[] args)
        { 
            TimSoChanLe();

           


        }
    }
}
