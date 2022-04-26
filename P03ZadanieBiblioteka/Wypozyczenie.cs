using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieBiblioteka
{
    internal class Wypozyczenie
    {
        public DateTime DataWypozyzenia;
        public DateTime PrzewidywanaDataZwrotu;
        public DateTime DataRzeczywistegoZwrotu;
        public Czytelnik Czytelnik;
        public string Uwagi;
        public Sygnatura Sygnatura;
        public int Kara;
        public Wypozyczenie Przedluzenie;
    }
}
