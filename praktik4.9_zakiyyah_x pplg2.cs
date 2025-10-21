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
            Console.WriteLine("Masukkan sebuah bilangan: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("Bilangan positif.");
                if (angka % 2 == 0)
                    Console.WriteLine("Bilangan genap.");
                else
                    Console.WriteLine("Bilangan ganjil.");
            }
            else if (angka > 0)
            {
                Console.WriteLine("Bilangan negatif.");
                if (angka % 2 == 0)
                    Console.WriteLine("Bilangan genap.");
                else
                    Console.WriteLine("Bilangan ganjil.");
            }
            else
            {
                Console.WriteLine("Bilangan nol.");
            }
        }
    }
}
