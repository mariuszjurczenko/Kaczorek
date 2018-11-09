﻿using Common;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Klient : KlasaBazowa, ILogowanie
    {
        #region konstruktory
        public Klient() : this(0)
        {
           
        }

        public Klient(int klientId)
        {
            KlientId = klientId;
            ListaAdresow = new List<Adres>();
        }
        #endregion

        #region właściwości
        // Właściwości
        public static int Licznik { get; set; }

        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                // tutaj możemy dodac dowolny kod
                return _nazwisko;
            }
            set
            {
                // tutaj możemy dodac dowolny kod
                _nazwisko = value;
            }
        }

        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;

                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }

                return imieNazwisko;
            }
        }

        public List<Adres> ListaAdresow { get; set; }

        public int KlientTyp { get; set; }

        #endregion

        #region metody
        // Metody
        public override bool Zwalduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko))
                poprawne = false;
            if (string.IsNullOrWhiteSpace(Email))
                poprawne = false;

            return poprawne;
        }

        /// <summary>
        /// Zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod, który zapisuje zdefiniowanego klienta
            return true;
        }

        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //Kod który pobiera określonego klienta
            return new Klient();
        }

        /// <summary>
        /// Pobieramy wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            //Kod który pobiera wszystkich klientów
            return new List<Klient>();
        }

        public override string ToString()
        {
            return ImieNazwisko;
        }

        public string Log()
        {
            var log = KlientId + ": " + 
                ImieNazwisko + " " + 
                "Email: " + Email + " " + 
                "Status: " + StanObiektu.ToString();

            return log;
        }

        #endregion
    }
}