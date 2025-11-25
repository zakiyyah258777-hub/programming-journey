using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_konversi_suhu
{
    internal class Program
    {
        static double KonversiSuhu(double c)
        {
            double f = (c * 9 / 5) = 32;
            return f;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan suhu dalam celcius: ");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = KonversiSuhu(celcius);
            Console.WriteLine("Suhu dalam Fahrenheit adalah: " + fahrenheit);
        }
    }
}
