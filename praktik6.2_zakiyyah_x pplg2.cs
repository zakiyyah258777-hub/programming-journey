using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contoh_for2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untuk menyimpan hasil penjumlahan
            int total = 0;

            Console.WriteLine("Menghitung jumlah angka dari 1 sampai 5:");

            // Peerulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++)
            {
                //Tambahkan nilai i saat ini ke variabel total
                total = total + i; //bisa juga ditulis sebagai: += i;

                //Tampilkan proses penjumlahan di setiap langkah
                Console.WriteLine("Menambahkan " + i + ",total sementara = " + total);
            }
            // Tmpilkan hasil akhir setelah perulangan selesai
            Console.WriteLine("\nHasil akhir penjumlahan adalah: " + total);
        }
    }
}
