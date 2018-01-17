using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSoThuTuTangDan
{
    class Program
    {
        public static void InSoThuTuTangDan()
        {
            int n;
            Console.Write("Nhap 1 so nguyen n gom 3 chu so bat ky : ");
            n = int.Parse(Console.ReadLine());

            int _hangTram, _hangChuc, _hangDonVi;

            _hangTram = (n / 100);

            _hangChuc = (n / 10);

            _hangChuc = _hangChuc % 10;

            _hangDonVi = n % 100;

            _hangDonVi = _hangDonVi % 10;

            int max = _hangTram;
            if(max < _hangChuc)
            {
                max = _hangChuc;
            }
            if(max < _hangDonVi)
            {
                max = _hangDonVi;
            }

            int min = _hangTram;
            if(min > _hangChuc)
            {
                min = _hangChuc;
            }
            if(min > _hangDonVi)
            {
                min = _hangDonVi;
            }



            if (max == _hangTram && min == _hangDonVi)
            {
                Console.WriteLine("So duoc sap xep tang dan : {0}{1}{2}", _hangDonVi, _hangChuc, _hangTram);
            }
            else if (max == _hangTram && min == _hangChuc)

            {
                Console.WriteLine("So duoc sap xep tang dan : {0}{1}{2}", _hangChuc,_hangDonVi,_hangTram);
            }
            else if (max == _hangChuc && min == _hangTram)
            {
                Console.WriteLine("So duoc sap xep tang dan : {0}{1}{2}", _hangTram,_hangDonVi,_hangChuc);
            }
            else if (max == _hangChuc && min == _hangDonVi)
            {
                Console.WriteLine("So duoc sap xep tang dan : {0}{1}{2}", _hangDonVi, _hangTram, _hangChuc);
            }

            else if (max == _hangDonVi && min == _hangChuc)
            {
                Console.WriteLine("So duoc sap xep tang dan : {0}{1}{2}", _hangChuc,_hangTram,_hangDonVi);
            }
            else if (max == _hangDonVi && min == _hangTram)
            {
                Console.WriteLine("So duoc sap xep tang dan : {0}{1}{2}",_hangTram,_hangChuc,_hangDonVi);
            }

            





        }
        static void Main(string[] args)
        {
            InSoThuTuTangDan();
            Console.ReadKey();
        }
    }
}
