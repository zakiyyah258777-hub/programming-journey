using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usia_dan_jenis_kelamin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan jenis kelamin (L untuk laki-laki, P untuk perempuan): ");
            char jeniskelamin = Console.ReadLine().ToUpper()[0];

            Console.Write("Masukkan umur: ");
            int umur = int.Parse(Console.ReadLine());

            string kategori = "";

            if (jeniskelamin == 'L')
            {
                if (umur < 18)
                {
                    kategori = "laki laki remaja";
                }
                else
                {
                    kategori = "laki laki dewasa";
                }
            }
            else if (jeniskelamin == 'P')
            {
                if (umur < 18)
                {
                    kategori = "perempuan remaja";
                }
                else
                {
                    kategori = "perempuan dewasa";
                }
            }
            else
            {
                kategori = "Input jenis kelamin tidak valid. Gunakan L atau P.";
            }
        }
    }
}
