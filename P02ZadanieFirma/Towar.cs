using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieFirma
{
    enum Kategoria
    {
        Czerwone,
        Czarne,
        Zolte,
        Niebieskie
    }
    internal class Towar
    {
        public double Cena;
        public Kategoria Kategoria;
    }
}
