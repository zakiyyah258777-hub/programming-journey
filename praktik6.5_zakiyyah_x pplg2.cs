using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. inisialisasi variabel penghitung (counter)
            int angka = 1;

            Console.WriteLine("Menampilkan angka 1 sampai 20:");

            // 2. Blok 'do-While'
            do
            {
                // Tampilkan nilai variabel 'angka' saat ini

                Console.WriteLine("angka");

                // Tambahkannilai 'angka' sebanyak 1 (increment)
                angka++;

                // uji kondisi: Loop berlanjut selama 'angka' kurang dari atau sama dengan
            } while (angka <= 20 );

            Console.WriteLine("selesai");
        }
    }
}
