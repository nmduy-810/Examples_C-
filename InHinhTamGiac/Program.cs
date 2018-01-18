using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InHinhTamGiac
{
    class Program
    {
        public static void InHinhTamGiac()
        {
            Console.Write("Nhap do cao h bat ky : ");
            int h = int.Parse(Console.ReadLine());
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j <= 2*h; j++)
                {
                    if(j < h - i || j > h + i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.Write("\n");



            }


        }

        static void Main(string[] args)
        {
            InHinhTamGiac();
            Console.ReadKey();
        }
    }
}
