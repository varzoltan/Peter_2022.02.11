using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peter_2022._02._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            foreach(var i in tomb2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Tömb feltöltése
            Random veletlen = new Random();

            int[,] tomb3 = new int[5,6];
            for(int i = 0;i < tomb3.GetLength(0); i++)
            {
                for (int j = 0; j < tomb3.GetLength(1); j++)
                {
                    tomb3[i, j] = veletlen.Next(101);
                    Console.Write(tomb3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(tomb3[2,4]);

            Console.ReadKey();
        }
    }
}
