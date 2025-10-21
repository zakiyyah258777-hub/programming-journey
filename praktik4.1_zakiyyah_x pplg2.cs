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
            //Memeriksa apakah seseorang sudah remaja
            Console.WriteLine("Masukkan Usia anda : ");
            int usia = int.Parse(Console.ReadLine());
            if (usia >= 13)
            {
                Console.WriteLine("Anda Sudah memasuki masa remaja.");
            }
        }
    }
}
