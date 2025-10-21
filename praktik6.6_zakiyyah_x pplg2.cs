using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perulangan_do_while._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            // Blok 'do' akan dieksekusi minimal satu kali.
            do
            {
                Console.WriteLine("Masukkan angka genap: ");
                //Mencoba membaca input dari pengguna
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("input tidak valid. Silakan masukkan angka.");
                    //Jika input tidak valid, set anka = 1 (ganjil) agar loopberlanjut
                    angka = 1;
                    continue; // Lanjutkan je iterasi berikutnya
                }
                //Memeriksa apakah angka tersebut ganjil
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"Angka {angka} adalah ganjil. Coba lagi.");
                }
                // Kondisi diperiksa di akhir. Loop berlanjut selama angka Ganjil.
            } while (angka % 2 != 0);
            Console.WriteLine($"Selamat! Anda memasukkan angka genap: {angka}");
        }
    }
}
