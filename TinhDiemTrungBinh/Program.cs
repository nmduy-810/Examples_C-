using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDiemTrungBinh
{
    class Program
    {

        public static void TinhDiemTrungBinh()
        {
            string _hoTen;
            double _diemToan, _diemLy, _diemHoa;
            Console.Write("Nhap ho ten : " );
            _hoTen = Console.ReadLine();
            Console.Write("Nhap diem Toan : ");
            _diemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem Ly : ");
            _diemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem Hoa : ");
            _diemHoa = double.Parse(Console.ReadLine());

            if(_diemToan < 0 || _diemHoa < 0 || _diemLy < 0)
            {
                Console.WriteLine("Xin nhap lai");
                return;
            }

            double _diemTrungBinh = ((_diemToan + _diemLy + _diemHoa) / 3);
            if(_diemTrungBinh >= 9.0)
            {
                Console.WriteLine("Hoc sinh XUAT SAC");
            }
            else if(_diemTrungBinh >= 8.0 && _diemTrungBinh < 9.0)
            {
                Console.WriteLine("Hoc sinh GIOI");

            }
            else if(_diemTrungBinh >= 6.5 && _diemTrungBinh < 8.0 )
            {
                Console.WriteLine("Hoc sinh KHA");

            }
            else if(_diemTrungBinh >= 5.0 && _diemTrungBinh <= 6.5)
            {
                Console.WriteLine("Hoc sinh TRUNG BINH");

            }
            else if(_diemTrungBinh >= 3.5 && _diemTrungBinh <= 5.0)
            {
                Console.WriteLine("Hoc sinh YEU");

            }
            else if(_diemTrungBinh <= 3.5)
            {
                Console.WriteLine("Hoc sinh KEM");

            }
            else
            {
                Console.WriteLine("KHONG CO HANG");
            }



        }
        static void Main(string[] args)
        {
            TinhDiemTrungBinh();
            Console.ReadKey();
        }
    }
}
