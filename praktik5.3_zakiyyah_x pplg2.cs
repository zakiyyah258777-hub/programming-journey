using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat rray untuk menyimpan nama dan nilai 3 siswa
            string[] nama = new string[3];
            int[] nilai = new int[3];

            // input nama dan nilai siswa dari keyboard
            Console.Write("Masukkan nama siswa ke-1: ");
            nama[0] = Console.ReadLine();
            Console.Write("Masukkan nilai siswa ke-1: ");
                nilai[0] = int.Parse(Console.ReadLine());


            Console.Write("Masukkan nama siswa ke-2: ");
            nama[1] = Console.ReadLine();
            Console.Write("Masukkan nilai siswa ke-2: ");
            nilai[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai siswa ke-3: ");
            nama[2] = Console.ReadLine();
            Console.Write("Masukkan nilai siswa ke-3: ");
            nilai[2] = Convert.ToInt32(Console.ReadLine());

            // Menampilkan hasil input tanpa perulangan
            Console.WriteLine("\n=== Dta Siswa ===");
            Console.WriteLine("nama: " + nama[0] + " | Nilai: " + nilai[0]);
            Console.WriteLine("nama: " + nama[1] + " | nilai: " + nilai[1]);
            Console.WriteLine("nama: " + nama[2] + " | nilai: " + nilai[2]);
        }
    }
}
