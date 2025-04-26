using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Điểm quá trình : ");
            double diemQT = double.Parse(Console.ReadLine());

            Console.WriteLine("Điểm thực hành  : ");
            double diemTH = double.Parse(Console.ReadLine());

            Console.WriteLine("Điểm thi cuối kỳ  : ");
            double diemCK = double.Parse(Console.ReadLine());

            double diemTrungBinh = (diemQT * 0.2) + (diemCK * 0.5) + (diemTH * 0.3);

            diemTrungBinh = Math.Round(diemTrungBinh, 1);

            Console.WriteLine($"Điểm trung bình môn học: {diemTrungBinh}");
            Console.ReadKey();

        }
    }
}
