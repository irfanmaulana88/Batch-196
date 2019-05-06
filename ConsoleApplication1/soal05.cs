using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Logic01Soal05
    {
        public static void Soal05a(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write(angka + " ");
                    angka += nIncrement;
                }
            }
            Console.WriteLine();
        }
    }
}
