using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottoka
{
    class Beolvasas
    {
        public void szambeolvas(List<int> szamok)
        {
            while (szamok.Count <= 4)
            {
                int szam = int.Parse(Console.ReadLine());
                if (szam >= 1 && szam < 90)
                {
                    if (szamok.Contains(szam))
                    {
                        Console.WriteLine("Ezt a szamot mar megadtad. Kerlek adj meg egy masik szamot.");
                    }
                    else
                    {
                        szamok.Add(szam);
                    }
                }
                else
                {
                    Console.WriteLine("Nem megfelelo szamot adtal meg, probald meg ujra");
                }
            }
        }
    }
}
