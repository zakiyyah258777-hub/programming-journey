using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perulanagn_while._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Inisialisasi variabel perhituangan(counter)
            int hitungan = 5;

            Console.WriteLine("Memulai hitunagn mundur:");
            //2.perulangan 'while'
            // Kondisi: selama nilai 'hitungan'lebih besar dari 0
            while (hitungan > 0)
            {
                //Blok kode di dalam perulangan
                Console.WriteLine($"Hitunngan: {hitungan}");

                //3.Updaet variabel penghitung (decrement/perulangan)
                //Ini penting agar perulangan tidak menjadi loop tak terbatas (infinite loop)
                hitungan = hitungan - 1;
                //atau bisa juga ditulis: hitungan--;
            }
            // Kode setelah perulangan selesai
            Console.WriteLine("Selesai! Hitungan mundur telah berakhir.");
        }
    }
}
