using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieFirma
{
    internal class Pracownik
    {
        public string Imie;
        public string Nazwisko;
        public double Pensja;
        public List<Faktura> Faktury = new List<Faktura>(); 

        public void WystawFakture()
        {
            throw new NotImplementedException();
        }
    }
}
