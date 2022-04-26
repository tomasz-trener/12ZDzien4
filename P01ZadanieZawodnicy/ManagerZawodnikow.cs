using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieZawodnicy
{
    //https://github.com/tomasz-trener/12DDzien3

    enum TypImportu
    {
        Zdalny,
        Loklany
    }
    internal class ManagerZawodnikow
    {
        private string sciezka;
        private List<string> bledneWiersze;
        private Zawodnik[] zawodnicy;
        private TypImportu typImportu;

        public List<string> BledneWiersze
        {
            get 
            { 
                return bledneWiersze; 
            }
        }


        public ManagerZawodnikow()
        {
            sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            typImportu = TypImportu.Zdalny;
        }

        public ManagerZawodnikow(string sciezka, TypImportu typImportu)
        {
            // tutaj jest kod wykonawyczy podobnie jak metodach
            string s = "ala makota";
            s = s.ToUpper();

            this.sciezka = sciezka;
            this.typImportu = typImportu;
            //Sciezka = "domylsna sciezka";
        }

        //public List<string> PodajBledneWiersze()
        //{
        //    return bledneWiersze;
        //}


        public GrupaKraj[] PodajSreniWzrostDlaKazdegoKraju()
        {
            string[] kraje = PodajKraje();

            List<GrupaKraj> wynik = new List<GrupaKraj>();
            foreach (var k in kraje)
            {
                int[] wzrosty = podajWzrosty(k);
                double sredniWzrost = PoliczSrednia(wzrosty);

                GrupaKraj g = new GrupaKraj()
                {
                    NazwaKraju = k,
                    SredniWzrost = sredniWzrost,
                };
                wynik.Add(g);
            }
            return wynik.ToArray();


            return zawodnicy.GroupBy(x => x.Kraj).Select(x => new GrupaKraj()
            {
                NazwaKraju = x.Key,
                SredniWzrost = x.Average(y => y.Wzrost)
            }).ToArray();
        }

        private int[] podajWzrosty(string kraj)
        {
            List<int> wzrosty = new List<int>();
            foreach (var z in zawodnicy)
                if (z.Kraj == kraj)
                    wzrosty.Add(z.Wzrost);

            return wzrosty.ToArray();
        }

        private string[] PodajKraje()
        {
            List<string> kraje = new List<string>();
            foreach (var z in zawodnicy)
                if (!kraje.Contains(z.Kraj))
                    kraje.Add(z.Kraj);

            return kraje.ToArray();
        }


        public Zawodnik[] WczytajZawodnikow()
        {
            string dane;
            if (typImportu == TypImportu.Zdalny)
                dane = new WebClient().DownloadString(sciezka);
            else if (typImportu == TypImportu.Loklany)
                dane = File.ReadAllText(sciezka);
            else
                throw new Exception("Nieznany typ importu");

            string[] wiersze =
               dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            bledneWiersze = new List<string>();
            List<Zawodnik> zawodnicy = new List<Zawodnik>();

            // Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length - 1];
            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                try
                {
                    Zawodnik ityZawodnik = new Zawodnik();
                    ityZawodnik.Id = Convert.ToInt32(komorki[0]);
                    //if(!string.IsNullOrEmpty(komorki[1]))
                    ityZawodnik.Id_trenera = Convert.ToInt32(komorki[1]);

                    ityZawodnik.Imie = komorki[2];
                    ityZawodnik.Nazwisko = komorki[3];
                    ityZawodnik.Kraj = komorki[4];
                    ityZawodnik.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                    ityZawodnik.Wzrost = Convert.ToInt32(komorki[6]);
                    ityZawodnik.Waga = Convert.ToInt32(komorki[7]);

                    // zawodnicy[i - 1] = ityZawodnik; // i-1 bo przesuniecie o 1 wzgldem naglowka 
                    zawodnicy.Add(ityZawodnik);
                }
                catch (Exception)
                {
                    bledneWiersze.Add(wiersze[i]);
                }
            }
            this.zawodnicy = zawodnicy.ToArray();
            return zawodnicy.ToArray();
        }

        public double PodajSredniWzrost()
        {
            int[] wzrosty = new int[zawodnicy.Length];
            for (int i = 0; i < zawodnicy.Length; i++)
                wzrosty[i] = zawodnicy[i].Wzrost;

            return PoliczSrednia(wzrosty);

            return zawodnicy.Select(x => x.Wzrost).Average();
        }

        public double PodajSredniWaga()
        {
            int[] wagai = new int[zawodnicy.Length];
            for (int i = 0; i < zawodnicy.Length; i++)
                wagai[i] = zawodnicy[i].Waga;

            return PoliczSrednia(wagai);

            return zawodnicy.Select(x => x.Waga).Average();
        }

        private double PoliczSrednia(int[] liczby)
        {
            double suma = 0;
            foreach (var e in liczby)
                suma += e;

            return suma / liczby.Length;
        }


    }
}
