using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lottoka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek add meg a számaid a ötöslottó húzáshoz");
            int[] huzasok = new int[4];
            string[] fajl;
            List<int> szamok = new List<int>();
            Beolvasas(szamok);
            var utvonal = @"otos.csv";
            using (StreamReader sr = new StreamReader(utvonal))
            {
                while (!sr.EndOfStream)
                {
                    fajl = sr.ReadLine().Split(';');
                    int counter = 0;
                    for (int i = 11; i < 16; i++)
                    {
                        szamok.Contains(int.Parse(fajl[i]));
                        if (szamok.Contains(int.Parse(fajl[i])))
                        {
                            counter++;
                        }
                    }
                    if (counter >= 2)
                    {
                        huzasok[counter - 2]++;
                    }
                }

            }
            Console.WriteLine("Kettes talalat:" + huzasok[0]);
            Console.WriteLine("Harmas talalat:" + huzasok[1]);
            Console.WriteLine("Negyes talalat:" + huzasok[2]);
            Console.WriteLine("Otos talalat:" + huzasok[3]);
            Console.ReadLine();
        }

        private static void Beolvasas(List<int> szamok)
        {
            while (szamok.Count <= 4)
            {
                int szam = int.Parse(Console.ReadLine());
                if (szamok.Contains(szam))
                {
                    Console.WriteLine("Ezt a szamot mar megadtad. Kerlek adj meg egy masik szamot.");
                }
                else
                {
                    szamok.Add(szam);
                }
            }
        }
    }
}
