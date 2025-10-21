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
            Console.WriteLine("Masukkan angka nya : ");
            int angka = int.Parse(Console.ReadLine());

            if (angka % 2 == 0)
            {
                Console.WriteLine("Angka" + angka + "adalah GENAP.");
            }
            else
            {
                Console.WriteLine("Angka" + angka + "adalah GANJIL");
            }
        }
    }
}
