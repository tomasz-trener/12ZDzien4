using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieBiblioteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta k = new Karta()
            {
                NrKarty = new int[2] { 1308, 0 },
                Tytul = "O kurdlach dla opornych",
                NrWydania = 1,
                Autorzy = new Autor[2]
                {
                    new Autor()
                    {
                        Imie="L",
                        Nazwisko="Tarantoga",
                        DrugieImie = "A"
                    },
                    new Autor()
                    {
                        Imie="I",
                        Nazwisko="Tichy",
                    },
                },
                dataZakupu = new DateTime(2000, 1, 27),
                Cena = new Cena()
                {
                    Wartosc = 17.5,
                    Uwagi = "(zakup z 18.08 – 20, 00)"
                },
                Sygnatury = new Sygnatura[2] 
                { 
                    new Sygnatura(){NumerSygnatury = 12370, Aktywna=true },
                    new Sygnatura()
                    {
                        NumerSygnatury = 12371, 
                        Aktywna=false ,
                        Komentarz = "(zgłoszona utrata 01.05.2000)",
                        Wypozyczenia = new Wypozyczenie[1]
                        {
                            new Wypozyczenie()
                            {
                                Czytelnik = new Czytelnik(){ Numer="B2354"},
                                DataWypozyzenia = new DateTime(2000,2,22),
                                PrzewidywanaDataZwrotu = new DateTime(2000,3,7),
                                Uwagi="06.03.2000 Zgoda na przedłużenie",
                                Przedluzenie = new Wypozyczenie()
                                {
                                    PrzewidywanaDataZwrotu = new DateTime(2000,3,15),
                                    DataRzeczywistegoZwrotu = new DateTime(2000,3,15)
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
