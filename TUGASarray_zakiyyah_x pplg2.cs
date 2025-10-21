using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySiswa
{
    public struct Siswa
    {
        public string Nama;
        public char JenisKelamin;
        public string Kelas;

        public Siswa(string nama, char jenisKelamin, string kelas)
        {
            Nama = nama;
            JenisKelamin = jenisKelamin;
            Kelas = kelas;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
                Siswa[] daftarSiswa = new Siswa[3];

                daftarSiswa[0] = new Siswa("Ari", 'L', "PPLG 1");
                daftarSiswa[1] = new Siswa("Alif", 'L', "X PPLG 2");
                daftarSiswa[2] = new Siswa("Anik", 'P', "X PPLG 2");

            Console.WriteLine("Daftar Siswa:");
            Console.WriteLine("=============");
            foreach (Siswa siswa in daftarSiswa)
            {
                Console.WriteLine($"Nama : {siswa.Nama}");
                Console.WriteLine($"Jenis Kelamin: {siswa.JenisKelamin}");
                Console.WriteLine($"Kelas: {siswa.Kelas}");
                Console.WriteLine("---");
            }
            Console.ReadKey();
        }
    }
}
