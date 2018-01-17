using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTienTaxi
{
    class Program
    {

        public static void TinhTienTaxi()
        {
            double _soKilomet;
            Console.Write("Nhap so km di duoc : ");
            _soKilomet = double.Parse(Console.ReadLine());

            double _soTien = 12000;
            if(_soKilomet == 1)
            {               
                _soTien *= _soKilomet;
            }

            if(_soKilomet >= 2 && _soKilomet <= 5)
            {
                _soTien = 10500;
                _soTien *= _soKilomet;              

            }
            else if(_soKilomet >= 6 && _soKilomet <= 140)
            {
                _soTien = 9000;
                _soTien *= _soKilomet;
                
            }
            else if(_soKilomet > 140)
            {
                _soTien = 9000;
                _soTien *= _soKilomet;
                double _phamTram  = ((_soTien * 12 ) / 100);
                _soTien -= _phamTram;

            }         

            Console.WriteLine( _soKilomet + " km ban di duoc co tong tien la " + _soTien + " VND ");
        }

        static void Main(string[] args)
        {
            TinhTienTaxi();
            Console.ReadKey();
        }
    }
}
