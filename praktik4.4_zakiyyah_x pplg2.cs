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
            Console.WriteLine("Silakan login : ");
            string user = (Console.ReadLine());

            if (user == "admin")
            {
                Console.WriteLine("Selamat datang kembali, User!");
            }
            else
            {
                Console.WriteLine("Silakan login terlebih dahulu.");
            }
        }
    }
}
