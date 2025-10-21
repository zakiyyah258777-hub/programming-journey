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
            Console.WriteLine("Masukkan pilihan anda : (1-7)");
            int hari = Convert.ToInt32(Console.ReadLine());
            switch (hari)
            {
                case 1:
                    Console.WriteLine("Hari Senin");
                    break;
                case 2:
                    Console.WriteLine("Hari Selasa");
                    break;
                case 3:
                    Console.WriteLine("Hari Rabu");
                    break;
                case 4:
                    Console.WriteLine("Hari Kamis");
                    break;
                case 5:
                    Console.WriteLine("Hari Jumat");
                    break;
                case 6:
                    Console.WriteLine("Hari Sabtu");
                    break;
                case 7:
                    Console.WriteLine("Hari MInggu");
                    break;
                default:
                    Console.WriteLine("Nomor hari tidak valid!");
                    break;
            }
        }
    }
}
