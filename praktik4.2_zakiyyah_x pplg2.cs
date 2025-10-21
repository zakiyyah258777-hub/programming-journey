using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contoh_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Memeriksa apakah sebuah bilangan positif
            Console.WriteLine("Masukkan suhu nya : ");
            double suhu = double.Parse(Console.ReadLine());

            if (suhu > 0)
            {
                Console.WriteLine("Suhu di atas titik bekub (positif).");

            }
        }
    }
}
