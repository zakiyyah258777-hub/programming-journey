using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilai_siswa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nama siswa: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan nilai Matematika: ");
            double nilaiMat = double.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai Bahasa Indonesisa: ");
            double nilaiIndo = double.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai Bahasa Inggris: ");
            double nilaiEng = double.Parse(Console.ReadLine());

            double total = nilaiMat + nilaiIndo + nilaiEng;
            double rataRata = total / 3.0;

            string grade;
            if (rataRata >= 84)
            {
                grade = "A";
            }
            else if (rataRata >= 75 && rataRata <= 84)
            {
                grade = "B";
            }
            else if (rataRata >= 65 && rataRata <= 74)
            {
                grade = "C";
            }
            else if (rataRata >= 55 && rataRata <= 64)
            {
                grade = "D";
            }
            else
            {
                grade = "E";
            }
            string status = (rataRata >= 75) ? "LULUS" : "TIDAK LULUS";

            Console.WriteLine("\n--- HASIL NILAI ---");
            Console.WriteLine($"Nama Siswa: {nama}");
            Console.WriteLine($"Nilai Matematika: {nilaiMat}");
            Console.WriteLine($"Nilai Bahasa Indonesia: {nilaiIndo}");
            Console.WriteLine($"Nilai Bahasa Inggris: {nilaiEng}");
            Console.WriteLine($"Total Nilai: {total}");
            Console.WriteLine($"Rata-rata Nilai: {rataRata:F2}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Status: {status}");

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();

        }
    }
}
