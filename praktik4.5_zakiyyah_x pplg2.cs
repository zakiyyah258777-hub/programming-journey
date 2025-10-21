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
            // login user, benar jika user ="admin"
            Console.WriteLine("Masukkan Nilai Ujian : ");
            int nilaiUjian = int.Parse(Console.ReadLine());

            if (nilaiUjian >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (nilaiUjian >= 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (nilaiUjian >= 60)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: D");
            }
        }
    }
}
