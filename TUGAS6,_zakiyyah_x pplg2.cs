using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumlahBilangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0; // Inisialisasi variabel untuk menyimpan total
            int i = 1; // Inisialisasi untuk bilangan awal

            while (i <= 5) // Perulangan while berjalan selama i kurang dari atau sama dengan 5.
            {
                total += i; // tambahkan nilai i ke total
                i++;  // Increment i untuk melanjutkan ke bilangan berikutnya
            }

            Console.WriteLine("Total = " + total);  //Tampilkan hasil
        }
    }
}
