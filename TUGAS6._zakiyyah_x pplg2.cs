using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelPerkalian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // loop untuk menampilakan tabel perkalian 5 dari 1 hingga 10.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("5 x" + i + " = " + (5 * i));
            }
        }
    }
}
