using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongSoChan
{
    class Program
    {
        public static int TinhTongCacSoChan()
        {

            int tong = 0;
            Console.Write("Nhap n so nguyen bat ky : ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0) return 0;
            if(n>0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if(i % 2 == 0)
                    {
                        tong += i;
                    }
                }
            }

            return tong;

        }
        static void Main(string[] args)
        {
            int res = TinhTongCacSoChan();
            Console.WriteLine("Tong cac so chan = " + res);
        }
    }
}
