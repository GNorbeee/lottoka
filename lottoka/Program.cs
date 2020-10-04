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
            Beolvasas beolvas = new Beolvasas();
            for (int i = 0; i < 5; i++)
            {
                beolvas.szambeolvas(szamok);
            }
            var utvonal = "otos.csv";
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
            Kiiras kiir = new Kiiras();
            kiir.kiirja(huzasok);
            Console.ReadLine();
        }
    }
}
