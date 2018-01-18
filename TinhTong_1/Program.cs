using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTong_1
{
    class Program
    {
        //Đề : Tính tổng S = 1 + 2 + ..... + n với n được nhập từ người dùng
        public static int TinhTong()
        {
            Console.Write("Nhap 1 so nguyen n bat ky : ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0) return 0;
                
            int tong = 0;
            for (int i = 0; i <= n; i++)
            {
                tong += i;
            }
            return tong;

        }

        static void Main(string[] args)
        {
            int res = TinhTong();
            Console.WriteLine("Tong = " + res);
            Console.ReadKey();
        }
    }
}
