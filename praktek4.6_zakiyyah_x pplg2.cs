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
            Console.WriteLine("Masukkan Berat Badan Anbda : ");
            double bb = double.Parse(Console.ReadLine());

            Console.WriteLine("Masukkan Tinggi Badan Anda");
            double tb = double.Parse(Console.ReadLine());

            double bmi = bb / (tb * tb);

            Console.WriteLine("BMI Anda: " + bmi.ToString("0.00"));

            if (bmi < 18.5)
            {
                Console.WriteLine("Kategori: Berat badan kurang.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Kategori: Berat badan normal.");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Kategori: Berat badan berlebih.");
            }
            else
            {
                Console.WriteLine("Kategori: Obesitas.");
            }
        }
    }
}
