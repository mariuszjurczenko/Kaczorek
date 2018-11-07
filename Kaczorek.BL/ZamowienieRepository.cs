using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class ZamowienieRepository
    {
        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zmowienie = new Zamowienie(zamowienieId);

            //Kod który pobiera określony produkt

            // tymczasowo zakodowane wartosci zamowienia
            if (zamowienieId == 10)
            {
                zmowienie.DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));
            }

            return zmowienie;
        }

        /// <summary>
        /// Pobieramy wszystkie zamowienia
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> Pobierz()
        {
            //Kod który pobiera wszystkie zamowienia
            return new List<Zamowienie>();
        }

        /// <summary>
        /// Zapisuje zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod, który zapisuje zdefiniowane zamowienie
            return true;
        }

        /// <summary>
        /// Pobieramy jedno zamówienie do wyswietlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            //Kod który pobiera zdefiniowane pola zamowienia 

            // Tymczasowe dane zakodowane na stałe
            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "Jacek";
                wyswietlanieZamowienia.Nazwisko = "Kowal";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2018, 5, 21, 12, 00, 00, new TimeSpan(5, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Mila",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "44-400"
                };
                wyswietlanieZamowienia.WyswietlaniePozycjZamowieniaLista = new List<WyswietlaniePozycjZamowienia>();

                // Kod, który pobiera elementy zamówienia

                // Tymczasowe dane zakodowane na stałe
                if (zamowienieId == 10)
                {
                    var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjZamowienia()
                    {
                        NazwaProduktu = "Stol",
                        CenaZakupu = 300.50M,
                        Ilosc = 10
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);

                    wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjZamowienia()
                    {
                        NazwaProduktu = "blat",
                        CenaZakupu = 50.33M,
                        Ilosc = 5
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
                }

            }

            return wyswietlanieZamowienia;
        }
    }
}