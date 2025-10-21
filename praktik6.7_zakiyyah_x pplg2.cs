using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perulangan_do_while._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                // Tamppilkan menu
                Console.WriteLine("\n=== Menu Aplikasi ===");
                Console.WriteLine("1. Lihat Data");
                Console.WriteLine("2. tambah Data");
                Console.WriteLine("3. Keluar");
                Console.WriteLine("Masukkan pilihan Anda (1-3): ");

                //Baca input pengguna
                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("Pilihan tidak valid.harap masukkan angka 1, 2, atau 3.");
                    pilihan = 0;
                    continue;
                }
                //Proses pilihan
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Anda memilih: Lihat Data.");
                        break;
                    case 2:
                        Console.WriteLine("Anda memilih: tambah Data.");
                        break;
                    case 3:
                        Console.WriteLine("Program akan berhenti...");
                        break; // Keluar dari switch
                    default:
                        Console.WriteLine("Pilihan di luar jangkauan. Harap masukkan 1, 2, atau 3.");
                        break;
                }
                // kondisi loop: Lanjutkan selama pilihan BUKAN 3.
            } while (pilihan != 3);
            Console.WriteLine("Terimaksih telah menggunakan aplikasi.");
        }
    }
}
