using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_contoh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
            {
                // --- Blok proses yang akan diulang ---
                Console.WriteLine("----------------------------------");
                Console.Write("Masukkan nama anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"halo, {nama}! Proses telah selesai.");
                // -------------------------------------
                // Pertanyaan untuk Mengulang
                Console.Write("Apakah anda ingin mengulang lagi? (ya/tidak): ");
                ulangiPilihan = Console.ReadLine().ToLower(); // Mengambil input dan mengubah ke huruf kecil

                Console.WriteLine(); // Baris kosong untukkerapian

                // kondisi diperiksa di akhir: Ulangi selama pengguna mengetik "ya"
            } while (ulangiPilihan == "ya");
              Console.WriteLine("Terima kasih.Program selesai. ");
        }
    }
}
