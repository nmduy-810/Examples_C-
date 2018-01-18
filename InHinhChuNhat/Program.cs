using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InHinhChuNhat
{
    class Program
    {
        public static void InHinhChuNhat()
        {
            
            Console.Write("Nhap chieu dai hinh chu nhat : ");
            int _chieuDai = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat : ");
            int _chieuRong = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < _chieuRong; i++)
            {
                Console.Write("*");
                for (int j = 0; j < _chieuDai; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }

        }
        static void Main(string[] args)
        {
            InHinhChuNhat();
            Console.ReadKey();
        }
    }
}
