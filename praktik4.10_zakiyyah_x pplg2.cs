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
            Console.WriteLine("Apakah Anda memiliki Kartu member? (y/n): ");
            char member = char.Parse(Console.ReadLine().ToLower());

            Console.Write("Masukkan total belanja: ");
            double total = double.Parse(Console.ReadLine());

            double diskon = 0;

            if (member == 'y')
            {
                if (total >= 500000)
                    diskon = 0.15; // 15%
                else if (total >= 250000)
                    diskon = 0.10; // 10%
                else
                    diskon = 0.05; // 5%
            }
            else
            {
                if (total >= 500000)
                    diskon = 0.05; // 5%
                else diskon = 0; // Tidak ada diskon
            }
            double totalBayar = total - (total * diskon);
            Console.WriteLine($"Diskon: {diskon * 100}%");
            Console.WriteLine($"Total yang ahrus dibayar: Rp {totalBayar}");
        }
    }
}
