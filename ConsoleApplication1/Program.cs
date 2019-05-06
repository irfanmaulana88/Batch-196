using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Soal01(7,1,2);
            Soal01(7,2,2);
            Soal01(7,1,3);
            Soal01(7,1,3);
            Soal02(8,1,4); // (8 = n , 1 = nAwal , 4 = nIncrement) //
            Soal03(8,1,4);
            Soal04(7, 2, 2);
            Soal04(7, 3, 3);
            Soal05(8, 4, 4);
            Soal06(8, 3, 3);
            Logic01Soal01.Soal101a(7, 1, 1);
            Logic01Soal05.Soal05a(8, 1, 4);
            Logic01Soal06.Soal06a(8, 1, 4);
            Console.ReadKey();
        }

        static void Soal01(int n,int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 0; i < n; i++)
            {
                Console.Write(angka+ " ");
                angka += nIncrement;
            }
            Console.WriteLine();
        }

        static void Soal02(int n,int nAwal, int nIncrement)
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

        static void Soal03(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("* ");
                    angka += nIncrement;
                }
                else
                {
                    Console.Write(angka + " ");
                    angka += nIncrement;
                }
            }
            Console.WriteLine();
        }

        static void Soal04(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 0; i < n; i++)
            {
                Console.Write(angka + " ");
                angka *= nIncrement;
            }
            Console.WriteLine();
        }

        static void Soal05(int n, int nAwal, int nIncrement)
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
                    angka *= nIncrement;
                }
            }
            Console.WriteLine();
        }
        static void Soal06(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("XXX ");
                    angka *= nIncrement;
                }
                else
                {
                    Console.Write(angka + " ");
                    angka *= nIncrement;
                }
            }
            Console.WriteLine();
        }
    }
}
