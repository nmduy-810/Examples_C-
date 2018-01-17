using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViTriSoLonNhat
{
    class Program
    {
        public static void TimViTriSoLonNhat()
        {
            double n;
            Console.Write("Nhap 1 so nguyen gom 3 chu so : ");
            n = double.Parse(Console.ReadLine());

            double _hangTram, _hangChuc, _hangDonVi;

            _hangDonVi = Convert.ToDouble(n % 10);

            _hangChuc = Convert.ToDouble(n % 100);

            _hangChuc = Convert.ToInt32(_hangChuc / 10);

            _hangTram = Convert.ToInt32(n / 100);

            double max = _hangTram;

            if(max < _hangChuc)
            {
                max = _hangChuc;
            }
            if(max < _hangDonVi)
            {
                max = _hangDonVi;
            }

            Console.WriteLine("So lon nhat la " + max);
           

            //Console.WriteLine(_hangDonVi);

            //Console.WriteLine(_hangChuc);

            //Console.WriteLine(_hangTram);

        }

        static void Main(string[] args)
        {
            TimViTriSoLonNhat();
            Console.ReadKey();
        }
    }
}
