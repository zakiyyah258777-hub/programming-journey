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
            Console.WriteLine("=== MENU MINUMAN ===");
            Console.WriteLine("1. Teh Manis");
            Console.WriteLine("2. Jus Jeruk");
            Console.WriteLine("3. Air Mineral");
            Console.Write("Pilih menu (1-3): ");

            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.WriteLine("Anda memesan Teh Manis.");
                    break;
                case "2":
                    Console.WriteLine("Anda memesan Jus Jeruk.");
                    break;
                case "3":
                    Console.WriteLine("Anda memesan Air Mineral.");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    break;
            }
        }
    }
}
