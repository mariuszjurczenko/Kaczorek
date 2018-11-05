﻿namespace Kaczorek.BL
{
    public class Klient
    {
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
                return Imie + "," + Nazwisko;
            }
        }
    }
}