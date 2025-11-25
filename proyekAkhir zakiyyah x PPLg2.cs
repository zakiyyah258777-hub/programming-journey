using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGARIPAT_FOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piilihan,jumlah;
            double harga = 0, total = 0;
            string menu = "";

            Console.WriteLine("=== SELAMAT DATANG DI NGARIPAT FOOD ===");
            Console.WriteLine("1. Ayam Geprek   : Rp 21.000");
            Console.WriteLine("2. Ayam Goreng   : Rp 17.000");
            Console.WriteLine("3. Udang Goreng  : Rp 19.000");
            Console.WriteLine("4. Cumi Goreng   : Rp 20.000");
            Console.WriteLine("5. Es Teh        : Rp 8.000");
            Console.WriteLine("6. Es Jeruk      : Rp 9.000");
            Console.Write("Silahkan pilih menu yang anda inginkan (1-6) : ");
            piilihan = Convert.ToInt32(Console.ReadLine());

            //tentukan harg aberrdasarkan pilihan
            switch (piilihan)
            {                 case 1:
                    menu = "Ayam Geprek";
                    harga = 21000;
                    break;
                case 2:
                    menu = "Ayam Goreng";
                    harga = 17000;
                    break;
                case 3:
                    menu = "Udang Goreng";
                    harga = 19000;
                    break;
                case 4:
                    menu = "Cumi Goreng";
                    harga = 20000;
                    break;
                case 5:
                    menu = "Es Teh";
                    harga = 8000;
                    break;
                case 6:
                    menu = "Es Jeruk";
                    harga = 9000;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia");
                    return;
            }
            Console.Write("Masukkan jumlah pesanan: ");
            jumlah = Convert.ToInt32(Console.ReadLine());

            //Hitung total harga
            total = harga * jumlah;

            Console.WriteLine();
            Console.WriteLine("=== STRUK PEMBAYARAN ===");
            Console.WriteLine("Menu       : " + menu);
            Console.WriteLine("Jumlah     : " + jumlah);
            Console.WriteLine("Total Harga: Rp " + total);
            Console.WriteLine("=========================");

            Console.WriteLine("Terima kasih telah berkunjung di NGARIPAT FOOD!");
            Console.WriteLine();
        }
    }
}
