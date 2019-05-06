using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Logic01Soal01
    {
        public static void Soal101a(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 0; i < n; i++)
            {
                Console.Write(angka +" " );
                angka += nIncrement;
            }
            Console.WriteLine();
        }
    }
}
