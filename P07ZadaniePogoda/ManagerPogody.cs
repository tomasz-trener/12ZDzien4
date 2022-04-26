using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadaniePogoda
{
    internal class ManagerPogody
    {
        private int temp;

        public int Temperatura { get { return temp; } }

        public double PodajTemperature(string miasto, Jednostka jd = Jednostka.Celcjusz)
        {
            const string url = "https://www.google.com/search?q=pogoda";
            const char znak = '°';
            const char znakKoncowy = '>';

            // pobranie zawartosci strony z dynmanicznie generowanym adresem url
            
            string dane =
                 new WebClient().DownloadString($"{url} {miasto}");


            int indx = dane.IndexOf(znak);
            if (indx == -1)
            {
                //Console.WriteLine("Nieznane miasto");
                throw new Exception("Nieznane miasto");
            }

            int aktualnaPozycja = indx - 1;
            while (dane[aktualnaPozycja] != znakKoncowy)
                aktualnaPozycja--;

            int dlugosc = indx - aktualnaPozycja;
            if (dlugosc > 4)
            {
                //Console.WriteLine("Nieznane miasto");
                //return;
                throw new Exception("Nieznane miasto");
            }

            string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1-2); // usuwam znaki oC
            temp = Convert.ToInt32(wynik);
            TransformatorJednostek tj = new TransformatorJednostek();
            return tj.ZamienTemprature(temp, jd, Jednostka.Celcjusz);

            //Console.WriteLine(wynik);
            //return wynik;
        }
    }
}
