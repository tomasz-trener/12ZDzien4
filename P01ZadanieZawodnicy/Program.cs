using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.WczytajZawodnikow();

            string s = "Średnia waga wynosi {0} a średni wzorst wynosi {1}";
            Console.WriteLine(string.Format(s,
                mz.PodajSredniWaga(), mz.PodajSredniWzrost()));

            GrupaKraj[] gk = mz.PodajSreniWzrostDlaKazdegoKraju();

            foreach (var g in gk)
                Console.WriteLine(g.NazwaKraju + " " + g.SredniWzrost);

            Console.ReadKey();
            
        }
    }
}
