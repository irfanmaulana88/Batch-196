using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic02
{
    class Program
    {
        static void Main(string[] args)
        {
            Soal01(7, 1, 3);
            Soal02(8, 1, 3);
            Soal03(5, 3, 2);
            Console.ReadKey();
        }

        static void Soal01(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 0; i < n; i++)
            {
                Console.Write(angka + " ");
                angka *= nIncrement;
            }
            Console.WriteLine();
        }

        static void Soal02(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
                if (i % 3 == 0)
                {
                    Console.Write(-angka + " ");
                    angka *= nIncrement;
                }
                else
                {
                    Console.Write(angka + " ");
                    angka *= nIncrement;
                }
            Console.WriteLine();
        }

        static void Soal03(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            int nT = (n - 1) / 2;
            Console.Write(nAwal + " ");
            for (int i = 0; i <= nT; i++)
            {
                angka *= nIncrement;
                Console.Write(angka + " ");
                
            }
            for (int i = nT+1 ; i < n; i++)
            {
                angka /= nIncrement;
                Console.Write(angka + " ");
                
            }
            Console.Write(nAwal + " ");
        }
    }
}
