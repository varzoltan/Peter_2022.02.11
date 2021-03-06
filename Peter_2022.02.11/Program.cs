using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Peter_2022._02._11
{
    internal class Program
    {
        struct Adat
        {
            public string Soduku;
        }
        static string hetnapja(int honap, int nap)
        {
            string[] napnev = { "vasarnap", "hetfo", "kedd", "szerda", "csutortok", "pentek", "szombat" };
            int[] napszam = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 335 };
            int napsorszam = (napszam[honap - 1] + nap) % 7;
            string hetnapja = napnev[napsorszam];
            return hetnapja;
        }

        static int osszead(int a,int b)
        {
            a = 10;
            b = 20;
            int osszesen = a + b;
            int szorzata = a * b;
            return szorzata;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(osszead(40,  50));
            int honap = 4;
            int nap = 4;
            Console.WriteLine(hetnapja(honap,  nap));
            //Tömbök
            //Egydimenziós tömbök: vektor
            //1-Ismerem az elemeit
            int[] tomb = { 1, 2, 3, 4, 5, 6 };//Létrehoztam a tömböt
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(tomb[5]);//Kiirja az 6
            foreach (var i in tomb)
            {
                Console.Write(i + " ");
            }
            //Nem ismert az elemek száma
            Console.WriteLine();

            int[] tomb2 = new int[10];
            foreach  (var i in tomb2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Tömb feltöltése
            Random veletlen = new Random();

            int[,] tomb3 = new int[5,  6];
            for  (int i = 0;  i < tomb3.GetLength(0); i++)
            {
                for (int j = 0; j < tomb3.GetLength(1); j++)
                {
                    tomb3[i, j] = veletlen.Next(101);
                    Console.Write(tomb3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(tomb3[2,  4]);
            vonalhuz();
            //szorzótábla
            //int[,] tomb4 = new int[10,10];
            Console.WriteLine();
            for (int i = 1;  i < 11;  i++)
            {
                for (int j = 1;  j < 11;  j++)
                {
                    Console.Write("{0,4}",  i * j);
                }
                Console.WriteLine();
            }
            vonalhuz();
            Console.Write("\nLégyszi add meg a születési időt: (1968.04.04)");
            string[] db = Console.ReadLine().Split('.');
            Console.WriteLine($"Ezen a napon születtél: {hetnapja(int.Parse(db[0]), int.Parse(db[1]), int.Parse(db[2]))}");
            vonalhuz();
            Console.ReadKey();
        }
        static string hetnapja(int ev, int ho, int nap)
        {
            string[] napok = { "v", "h", "k", "sze", "cs", "p", "szo" };
            int[] honapok = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4, };
            if (ho < 3)
            {
                ev = ev - 1;
            }
            return napok[ (ev + ev / 4 - ev / 100 + ev / 400 + honapok[ho - 1] + nap) % 7];
        }

        //Eljárás
        static void vonalhuz()
        {
            for (int i = 1;i<50;i++)
            {
                Console.Write('-');
            }
        } 
    }
}
