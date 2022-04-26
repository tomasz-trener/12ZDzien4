using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieBiblioteka
{
    internal class Karta
    {
        public int[] NrKarty;
        public string Tytul;
        public Autor[] Autorzy;
        public int NrWydania;
        public DateTime dataZakupu;
        public Cena Cena;
        public Karta Nastepna;
        public Karta Poprzednia;
        public Sygnatura[] Sygnatury;
    }
}
